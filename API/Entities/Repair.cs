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
        public string KeyWords { get; set; }
        public string Description { get; set; }
        public string WorkshopName { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
    }
}