using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class City:IEntity
    {
        [Key]
        public int CityId { get; set; }
       
        [Required(ErrorMessage = "Şehir adı girmeniz gerekmektedir")]
        public string CityName { get; set; }
        public ICollection<ShoppingCentre> ShoppingCentres { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Personal> Personals { get; set; }
    }
}
