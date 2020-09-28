using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required]
        public  string  ISBN { get; set; }

        [Display(Name = "Author Name")]
        [Required]
        public string Author { get; set; }

        [Required(ErrorMessage ="Publish Date id Required")]
        [Display(Name ="Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }


        [Required]
        public string Genre { get; set; }
    }
}
