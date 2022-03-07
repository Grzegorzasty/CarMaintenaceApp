using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IRepairRepository
    {
        public void AddRepair(Repair repair);
        public void EditRepair(Repair repair);
        public void DeleteRepair(Repair repair);
        Task<IEnumerable<RepairDto>> GetRepairsByVehicleIdAsync(int id);
        Task<RepairDetailsDto> GetRepairDetailsByIdAsync(int id);
        Task<Repair> GetRepairAsync(int id);
        Task<bool> SaveAllAsync();
    }
}