using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string  UserName { get; set; }
        public ICollection<VehicleDto> Vehicles { get; set; }
    }
}