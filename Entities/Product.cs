using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Kategori girmeniz gerekmektedir")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Mağaza girmeniz gerekmektedir")]
        public int ShoppingCentreId { get; set; }

        [Required(ErrorMessage = "Miktar girmeniz gerekmektedir")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Fiyat girmeniz gerekmektedir")]
        public double UnitPrice { get; set; }
        [Required(ErrorMessage = "Ürün adı girmeniz gerekmektedir")]
        public string ProductName { get; set; }

        public Category Category { get; set; }
        public ShoppingCentre ShoppingCentre { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
