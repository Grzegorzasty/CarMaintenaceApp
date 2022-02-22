using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   
    public class VehiclesController : BaseAppController
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public VehiclesController(IVehicleRepository vehicleRepository, IMapper mapper, IUserRepository userRepository)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpPost("add")]
        public async Task<ActionResult<VehicleDto>> CreateVehicle(AddVehicleDto addVehicleDto)
        {
            var vehicle = _mapper.Map<Vehicle>(addVehicleDto);
            
            _vehicleRepository.AddVehicle(vehicle);
            await _vehicleRepository.SaveAllAsync();

            return new VehicleDto{
                Manufacturer = addVehicleDto.Manufacturer,
                Model = addVehicleDto.Model
            };

        }
        
        [HttpGet("{username}")]
        public async Task<ActionResult<VehicleDto>> GetVehicles(string username)
        {
            var vehicles = await _vehicleRepository.GetVehicleByUsernameAsync(username);    
            return Ok(vehicles);
        }
        [HttpGet("edit/{id}")]
        public async Task<ActionResult<VehicleDetailDto>> GetVehicleDetails(int id)
        {
            var vehicle = await _vehicleRepository.GetVehicleDetailsByIdAsync(id);
            return Ok(vehicle);
        }
    }
}