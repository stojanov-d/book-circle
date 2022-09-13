using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookCircle.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "TEST")]
        public string BookTitle { get; set; }
        [DataType(DataType.MultilineText)]
        public string BookDescription { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public float BookRating { get; set; }
    }
}