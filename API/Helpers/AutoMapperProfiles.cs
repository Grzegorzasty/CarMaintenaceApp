using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>();
            CreateMap<Vehicle, VehicleDto>();
            CreateMap<AddVehicleDto, Vehicle>();
            CreateMap<Vehicle, VehicleDetailDto>();
            CreateMap<VehicleDetailDto, Vehicle>();
            CreateMap<AddRepairDto, Repair>();
            CreateMap<RepairDetailsDto, Repair>();
            CreateMap<Repair, RepairDto>();
            CreateMap<Repair, RepairDetailsDto>();
            CreateMap<Photo, PhotoDto>();
        }
    }
}