using System.ComponentModel.DataAnnotations;

namespace Magic_Villa_Web.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenities { get; set; }
        //public DateTime createdDate { get; set; }
    }
}
