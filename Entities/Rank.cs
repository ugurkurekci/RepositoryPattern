using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Rank:IEntity
    {
        [Key]
        public int Rankıd { get; set; }
        [MaxLength(25), MinLength(2)]
        [Required(ErrorMessage = "Ünvan adı girmeniz gerekmektedir")]
        public string RankName { get; set; }

        public ICollection<Personal> Personals { get; set; }
    }
}
