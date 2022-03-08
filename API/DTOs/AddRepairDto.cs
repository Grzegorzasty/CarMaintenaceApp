using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class AddRepairDto
    {
        //public DateTime DateOfReceipt { get; set; } = DateTime.Now;
        public int LaborPrize { get; set; }
        public int PartsPrize { get; set; }
        public bool EngineOilChange { get; set; } = false;
        public bool GearboxOilChange { get; set; } = false;
        public bool HydraulicOilChange { get; set; } = false;
        public bool EngineOilFilterChange { get; set; } = false;
        public bool GearboxOilFilterChange { get; set; } = false;
        public bool HydraulicOilFilterChange { get; set; } = false;
        public bool AirFilterChange { get; set; } = false;
        public bool CabinFilterChange { get; set; } = false;
        public bool FuelFilterChange { get; set; } = false;
        public bool BreakPadsChange { get; set; } = false;
        public bool BreakDiscsChange { get; set; } = false;
        public bool BreakFluidChange { get; set; } = false;
        public bool EngineCamChange { get; set; } = false;
        public bool CoolantChange { get; set; } = false;
        public string KeyWords { get; set; }
        public string Description { get; set; }
        public string WorkshopName { get; set; }
        public int VehicleId { get; set; }
       
    }
}