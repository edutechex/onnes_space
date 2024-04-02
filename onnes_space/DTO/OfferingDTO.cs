using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onnes_space.DTO
{
    public class AddOffering
    {
        public string content { get; set; }
        [NotMapped]
        public IFormFile? imageFile { get; set; }
        public string? title { get; set; }
        //public string name { get; set; }

    }

    public class EditOffering
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile? imageFile { get; set; }
        public string content { get; set; }
        public string? title { get; set; }
       // public string name { get; set; }
    }
}
