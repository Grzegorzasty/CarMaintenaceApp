using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<VehicleDto>> GetVehicleByUsernameAsync(string username);
        Task<VehicleDto> GetVehicleByIdAsync(int id);
    }
}