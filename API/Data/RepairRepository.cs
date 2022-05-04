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
    public class RepairRepository : IRepairRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RepairRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddRepair(Repair repair)
        {
            _context.Repair.Add(repair);
        }

        public void DeleteRepair(Repair repair)
        {
            _context.Repair.Remove(repair);
        }
        public void DeletePhoto(Photo photo)
        {
            _context.Photo.Remove(photo);
        }

        public void EditRepair(Repair repair)
        {
            _context.Entry(repair).State = EntityState.Modified;
        }

        public async Task<Repair> GetRepairAsync(int id)
        {
            return await _context.Repair.FindAsync(id);
        }

        public async Task<RepairDetailsDto> GetRepairDetailsByIdAsync(int id)
        {
            return await _context.Repair.Where(x => x.Id == id).ProjectTo<RepairDetailsDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RepairDto>> GetRepairsByVehicleIdAsync(int id)
        {
            return await _context.Repair.Where(x => x.VehicleId == id).ProjectTo<RepairDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
           var xd = await _context.SaveChangesAsync() > 0;
           return xd;
        }
    }
}