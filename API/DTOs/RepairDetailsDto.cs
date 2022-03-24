using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class RepairDetailsDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int LaborPrice { get; set; }
        public int PartsPrice { get; set; }
        public string KeyWords { get; set; }
        public string CheckBoxValues { get; set; }
        public string Description { get; set; }
        public string WorkshopName { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}