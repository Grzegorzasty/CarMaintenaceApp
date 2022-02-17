using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class AddVehicleDto
    {
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public string VinNumber { get; set; }
        public int PurchasePrize { get; set; }
        public string Description { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public string UserName { get; set; }
    }
}
