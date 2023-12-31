﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Muntean_Alexia_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; } //navigation property
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
