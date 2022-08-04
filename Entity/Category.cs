using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Desc { get; set; }
    }
}