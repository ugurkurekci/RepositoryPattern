using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Country : IEntity
    {
        [Key]
        public int CountryId { get; set; }
        [MaxLength(5)]
        [Required(ErrorMessage = " Ülke kodu girmeniz gerekmektedir")]
        public string CountryCode { get; set; }
        [Required(ErrorMessage = " Ülke ismi girmeniz gerekmektedir")]
        public string CountryName { get; set; }

        public ICollection<ShoppingCentre> ShoppingCentres { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Personal> Personals { get; set; }
    }
}
