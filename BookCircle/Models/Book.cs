using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCircle.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public float BookRating { get; set; }
    }
}