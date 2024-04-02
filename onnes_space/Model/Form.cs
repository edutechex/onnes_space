using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onnes_space.Model
{
    public class Form
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }
}
