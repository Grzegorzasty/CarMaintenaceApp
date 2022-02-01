using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}