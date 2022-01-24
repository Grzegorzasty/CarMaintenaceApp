using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public int LaborPrize { get; set; }
        public int PartsPrize { get; set; }
        public bool OilChange { get; set; }
        public bool OilFilterChange { get; set; }
        public bool AirFilterChange { get; set; }
        public bool CabinFilterChange { get; set; }
        public bool FuelFilterChange { get; set; }
        public string Parts { get; set; }
        public string Description { get; set; }
        public ICollection<Workshop> Workshops { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
    }
}