using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public  class Order:IEntity
    {
        [Key]
        public int OrderId { get; set; }
     
        public int? ProductId { get; set; }
        
        public int CustomerId { get; set; }
        public DateTime CreationDate { get; set; }
        [Required(ErrorMessage = "Adres girmeniz gerekmektedir")]
        public string Adress { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
