using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onnes_space.DTO
{
    public class AddCarouselImage
    {
        [NotMapped]
        public IFormFile? imageFile { get; set; }
        public string? text { get; set; }
        public string? order { get; set; }
        public string? colour { get; set; }
    }
   
    public class EditCarouselImage
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile? imageFile { get; set; }
        public string? text { get; set; }
        public string? order { get; set; }
        public string? colour { get; set; }
    }
}
