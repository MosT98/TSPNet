using System.ComponentModel.DataAnnotations;

namespace MyPhotosWEB.Models
{
    public class UserDTO
    {
        [Key]
        public System.Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
