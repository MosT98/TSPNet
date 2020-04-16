using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public partial class User
    {
        public User GetUserById(Guid id)
        {
            Model1Container context = new Model1Container();
            var user = context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != default(User))
            {
                return user;
            }
            return null;
        }

        public List<User> GetUsers()
        {
            Model1Container context = new Model1Container();
            var users = context.Users.ToList();
            return users;
        }

        public bool DeleteUser(Guid id)
        {
            Model1Container context = new Model1Container();
            var user = context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != default(User))
            {
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public void UpdateUser(Guid id, string firstName, string lastName, string email, string password)
        {
            Model1Container context = new Model1Container();
            var user = context.Users.FirstOrDefault(u => u.UserId == id);
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.Password = password;
            context.SaveChanges();
        }

        public void Register(string firstName, string lastName, string email, string password)
        {
            Model1Container context = new Model1Container();
            var user = MyPhotos.User.CreateUser(firstName, lastName, email, password);
            context.Users.Add(user);
            context.SaveChanges();
        }

        public Guid Login(string email, string password)
        {
            Model1Container context = new Model1Container();
            var checkUser = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (checkUser != default(User))
            {
                return checkUser.UserId;
            }

            return default(Guid);
        }
    }
}
