using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Kategori adı girmeniz gerekmektedir")]
        public string CategoryName { get; set; }


        public ICollection<Product> Products { get; set; }

    }
}
