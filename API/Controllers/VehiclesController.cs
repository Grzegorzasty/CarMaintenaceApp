using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class VehiclesController : BaseAppController
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehiclesController(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }
        
        [HttpGet("{username}")]
        public async Task<ActionResult<VehicleDto>> GetVehicles(string username)
        {
            var vehicles = await _vehicleRepository.GetVehicleByUsernameAsync(username);    
            return Ok(vehicles);
        }
        [HttpGet("details/{id}")]
        public async Task<ActionResult<VehicleDto>> GetVehicle(int id)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(id);
            return Ok(vehicle);
        }
    }
}