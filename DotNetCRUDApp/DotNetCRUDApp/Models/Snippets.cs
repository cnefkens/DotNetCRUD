using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DotNetCRUDApp.Models
{
    public class Snippets
    {
        public int Id { get; set; }
        [Required]
        [StringLength(75, MinimumLength = 4)]
        [Display(Name = "Title")]
        public string title { get; set; }
        [StringLength(255, MinimumLength = 4)]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [StringLength(2000, MinimumLength = 4)]
        [Display(Name = "Snippet")]
        public string snippet { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Language")]
        public string language { get; set; }
    }
}
