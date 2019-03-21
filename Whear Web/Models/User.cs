using System.ComponentModel.DataAnnotations;

namespace Whear.Web.Models
{
    // [To-do] String lengths.
    public class User
    {
        [Required]
        public int ID { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}