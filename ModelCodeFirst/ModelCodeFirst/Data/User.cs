using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelCodeFirst.Data
{
    public class User
    {
        [Key]
        public Guid ClientId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        public User()
        {
            this.ClientId = Guid.NewGuid();
        }

        public static User Create(String firstN, String lastN, String email, String password)
        {
            return new User
            {
                ClientId = Guid.NewGuid(),
                FirstName = firstN, 
                LastName = lastN, 
                Email = email,
                Password = password
            };
        }
    }
}
