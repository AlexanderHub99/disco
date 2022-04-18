using System.ComponentModel.DataAnnotations;

namespace MyFirstApplication.Models
{

    public class GuesResponse
    {
        [Required(ErrorMessage = "Please enter your mame.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter youe email address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please entr a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}