using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = " İsim girmeniz gerekmektedir")]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = " Soyisim girmeniz gerekmektedir")]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required(ErrorMessage = " Yaş girmeniz gerekmektedir")]

        public int Age { get; set; }
        [Required(ErrorMessage = " Kimlik numarası girmeniz gerekmektedir")]
        [MinLength(11), MaxLength(11)]
        public string IdentityNumber { get; set; }
        [RegularExpression("([0-9]+)", ErrorMessage = " Geçerli bir format giriniz")]
        [Required(ErrorMessage = " Telefon girmeniz gerekmektedir")]
        public string Phone { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Adress { get; set; }

        public City City { get; set; }
        public Country Country { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
