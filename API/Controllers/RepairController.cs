using System;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RepairController : BaseAppController
    {
        private readonly IMapper _mapper;
        private readonly IRepairRepository _repairRepository;
        private readonly IPhotoService _photoService;

        public RepairController(IMapper mapper, IRepairRepository repairRepository, IPhotoService photoService)
        {
            _repairRepository = repairRepository;
            _photoService = photoService;
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
        [HttpGet("{id}", Name ="GetRepair")]
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
        [HttpPost("{id}/add-photo")]
        public async Task<ActionResult<PhotoDto>> AddPhoto(IFormFile file, int id)
        {
            var repair = await _repairRepository.GetRepairAsync(id);

            var result = await _photoService.AddPhotoAsync(file);

            if(result.Error != null) return BadRequest(result.Error.Message);

            var photo = new Photo
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };
            
            repair.Photos.Add(photo);
           

            if(await _repairRepository.SaveAllAsync())
            {   
                return CreatedAtRoute("GetRepair", new {id = repair.Id}, _mapper.Map<PhotoDto>(photo));
            } 

            return BadRequest("Problem adding photo");
        }

        [HttpDelete("{repairId}/delete-photo/{photoId}")]
        public async Task<ActionResult> DeletePhoto(int photoId, int repairId){
            
            var repair = await _repairRepository.GetRepairDetailsByIdAsync(repairId);

            var photo = repair.Photos.FirstOrDefault(x => x.Id == photoId);

            if(photo == null) return NotFound();

            if(photo.PublicId != null)
            {   
                var result = await _photoService.DeletePhotoAsync(photo.PublicId);

                if(result.Error != null) return BadRequest(result.Error.Message);
            }
            
            _repairRepository.DeletePhoto(photo);

            if(await _repairRepository.SaveAllAsync()){
                return Ok();
            } 

            return BadRequest("Failed to delete photo");
        }
    }
}