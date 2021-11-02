using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ShoppingCentre : IEntity
    {
        [Key]
        public int ShoppingCentreId { get; set; }
        [MaxLength(25), MinLength(3)]
        [Required(ErrorMessage = "Mağaza adı girmeniz gerekmektedir")]
        public string ShoppingCentreName { get; set; }

        public int CountrId { get; set; }
        public int CityId { get; set; }
        public string Adress { get; set; }

        public Country Country { get; set; }
        public City City { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
