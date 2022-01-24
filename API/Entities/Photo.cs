using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; } 
        public string PublicId { get; set; }
        public Repair Repair { get; set; }
        public int RepairId { get; set; }
    }
}