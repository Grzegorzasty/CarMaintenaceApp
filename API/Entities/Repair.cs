using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int LaborPrice { get; set; }
        public int PartsPrice { get; set; }
        public string KeyWords { get; set; }
        public string CheckBoxValues { get; set; }
        public string Description { get; set; }
        public string WorkshopName { get; set; }
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
    }
}