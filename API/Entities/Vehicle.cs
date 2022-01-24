using System.Collections.Generic;

namespace API.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public string VinNumber { get; set; }
        public int PurchasePrize { get; set; }
        public string Description { get; set; }
        public ICollection<Repair> Repairs { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}