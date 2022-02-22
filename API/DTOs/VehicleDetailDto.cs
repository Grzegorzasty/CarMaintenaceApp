using API.Entities;

namespace API.DTOs
{
    public class VehicleDetailDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public string VinNumber { get; set; }
        public int PurchasePrize { get; set; }
        public string Description { get; set; }
    }
}
