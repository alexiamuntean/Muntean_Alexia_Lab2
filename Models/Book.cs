using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Muntean_Alexia_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Titlul cartii este obligatoriu.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul cartii trebuie sa aiba între 3 și 150 de caractere.")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
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
