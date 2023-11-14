using System.ComponentModel.DataAnnotations;

namespace Muntean_Alexia_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage =
 "Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")]


        [StringLength(30, MinimumLength = 3)]

        public string? FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]

        public string? LastName { get; set; }

        [StringLength(70)]

        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string? Adress { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }

        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = 
 "Numărul de telefon trebuie să înceapă cu 0 și să conțină în total 10 cifre.")]
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}