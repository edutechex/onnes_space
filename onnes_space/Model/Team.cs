﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onnes_space.Model
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string about { get; set; }
        public string link { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string? image { get; set; }
    }
}
