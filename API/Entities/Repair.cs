using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int LaborPrize { get; set; }
        public int PartsPrize { get; set; }
        public bool EngineOilChange { get; set; }
        public bool GearboxOilChange { get; set; }
        public bool HydraulicOilChange { get; set; }
        public bool EngineOilFilterChange { get; set; }
        public bool GearboxOilFilterChange { get; set; }
        public bool HydraulicOilFilterChange { get; set; }
        public bool AirFilterChange { get; set; }
        public bool CabinFilterChange { get; set; }
        public bool FuelFilterChange { get; set; }
        public bool BreakPadsChange { get; set; }
        public bool BreakDiscsChange { get; set; }
        public bool BreakFluidChange { get; set; }
        public bool EngineCamChange { get; set; }
        public bool CoolantChange { get; set; }
        public string KeyWords { get; set; }
        public string Description { get; set; }
        public string WorkshopName { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
    }
}