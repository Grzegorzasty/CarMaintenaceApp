using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RepairController : BaseAppController
    {
        private readonly IMapper _mapper;
        private readonly IRepairRepository _repairRepository;

        public RepairController(IMapper mapper, IRepairRepository repairRepository)
        {
            _repairRepository = repairRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<RepairDto>> AddRepair(AddRepairDto addRepairDto)
        {
            var repair = _mapper.Map<Repair>(addRepairDto);
            _repairRepository.AddRepair(repair);
            await _repairRepository.SaveAllAsync();

            return NoContent();  
        }
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteRepair(int id)
        {
            var repair = await _repairRepository.GetRepairAsync(id);
            

            if(repair == null) return NotFound();

            _repairRepository.DeleteRepair(repair);
            
            if(await _repairRepository.SaveAllAsync()) return Ok();

            return BadRequest("Failed to delete repair");
        }
        [HttpPut]
        public async Task<ActionResult> UpdateRepair(RepairDetailsDto repairDetailsDto)
        {
            var repair = await _repairRepository.GetRepairAsync(repairDetailsDto.Id);
            
            _mapper.Map(repairDetailsDto, repair);
            
            _repairRepository.EditRepair(repair);
            
            if(await _repairRepository.SaveAllAsync()) return NoContent();
            
            return BadRequest("Failed to update repair");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RepairDetailsDto>> GetRepairDetailsByIdAsync(int id)
        {
            var repair = await _repairRepository.GetRepairDetailsByIdAsync(id);
            return Ok(repair);
        }
        [HttpGet("vehicle/{id}")]
        public async Task<ActionResult<RepairDto>> GetRepairByVehicleIdAsync(int id)
        {
            var repairs = await _repairRepository.GetRepairsByVehicleIdAsync(id);
            return Ok(repairs);
        }
    }
}