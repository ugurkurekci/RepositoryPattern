using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class About : IEntity
    {
        [Key]
        public int AboutId { get; set; }

        [MinLength(3)]
        [Required(ErrorMessage = "Veri girmeniz gerekmektedir")]
        public string Description { get; set; }

    }
}
