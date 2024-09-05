﻿using System.ComponentModel.DataAnnotations;

namespace onnes_space.Model
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Admintype { get; set; }
    }
}