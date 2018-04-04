using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)] //手工高亮
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //手工高亮
        [Required] //手工高亮
        [StringLength(30)] //手工高亮
        public string Genre { get; set; }

        [Range(1, 100)] //手工高亮
        [DataType(DataType.Currency)] //手工高亮
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //手工高亮
        [StringLength(5)] //手工高亮
        public string Rating { get; set; }
    }
}
