using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactId { get; set; }
        [RegularExpression("([0-9]+)", ErrorMessage = " Geçerli bir format giriniz")]
        [Required(ErrorMessage = " Telefon numarası girmeniz gerekmektedir")]
        public string Phone { get; set; }
        [Required(ErrorMessage = " İsim girmeniz gerekmektedir")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = " Soyisim girmeniz gerekmektedir")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email girmeniz gerekmektedir")]
        [EmailAddress]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = " Geçerli bir format giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Konu belirtmeniz gerekmektedir")]
        public string Subject { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = " Mesaj girmeniz gerekmektedir")]
        public string Message { get; set; }
    }
}
