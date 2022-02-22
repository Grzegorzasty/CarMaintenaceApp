using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public VehicleRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _context.Vehicle.Add(vehicle);
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            _context.Vehicle.Remove(vehicle);
        }

        public async Task<VehicleDto> GetVehicleByIdAsync(int id)
        {
            return await _context.Vehicle.Where(x => x.Id == id).ProjectTo<VehicleDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        public async Task<VehicleDetailDto> GetVehicleDetailsByIdAsync(int id)
        {
            return await _context.Vehicle.Where(x => x.Id == id).ProjectTo<VehicleDetailDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<VehicleDto>> GetVehicleByUsernameAsync(string username)
        {
            return await _context.Vehicle.Where(x => x.AppUser.UserName == username)
            .ProjectTo<VehicleDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}