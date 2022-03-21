using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class AddRepairDto
    {
        public DateTime DateOfReceipt { get; set; }
        public int LaborPrize { get; set; }
        public int PartsPrize { get; set; }
        public string KeyWords { get; set; }
        public string Description { get; set; }
        public string WorkshopName { get; set; }
        public int VehicleId { get; set; }
       
    }
}