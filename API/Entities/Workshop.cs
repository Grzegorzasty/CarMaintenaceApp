using System.Collections.Generic;

namespace API.Entities
{
    public class Workshop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public ICollection<Repair> Repair { get; set; }
        public int RepairId { get; set; }
    }
}