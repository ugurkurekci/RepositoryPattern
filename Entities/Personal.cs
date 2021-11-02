using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Personal : IEntity
    {
        [Key]
        public int PersonalId { get; set; }
        [Required(ErrorMessage = " Rütbe girmeniz gerekmektedir")]

        public int RankId { get; set; }
        [Required(ErrorMessage = " İsim girmeniz gerekmektedir")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = " Soyisim girmeniz gerekmektedir")]

        public string LastName { get; set; }
        [Required(ErrorMessage = " Referans girmeniz gerekmektedir")]

        public string ReferanceName { get; set; }
        [Required(ErrorMessage = " Maaş girmeniz gerekmektedir")]

        public double Wage { get; set; }
        [Required(ErrorMessage = " Kimlik girmeniz gerekmektedir")]

        public string IdentityNumber { get; set; }
        [Required(ErrorMessage = " Telefon girmeniz gerekmektedir")]
        [RegularExpression("([0-9]+)", ErrorMessage = " Geçerli bir format giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = " Ülke girmeniz gerekmektedir")]
        public int CountryId { get; set; }
        [Required(ErrorMessage = " Şehir girmeniz gerekmektedir")]
        public int CityId { get; set; }
        [Required(ErrorMessage = " Adres girmeniz gerekmektedir")]
        public string Adress { get; set; }

        public Rank Ranks { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
    }
}
