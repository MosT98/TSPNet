using MyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosWCF
{
    public class MyPhotos : IMyPhotos
    {
        public void AddPhoto(string name, string location, string description, string path, DateTime date, Guid idUser)
        {
            new Photo().AddPhoto(name, location, description, path, date, idUser);
        }

        public bool DeleteFolder(Guid id)
        {
            return new Folder().DeleteFolder(id);
        }

        public bool DeletePhoto(Guid id)
        {
            return new Photo().DeletePhoto(id);
        }

        public bool DeleteUser(Guid id)
        {
            return new User().DeleteUser(id);
        }

        public Folder GetFolderById(Guid id)
        {
            return new Folder().GetFolderById(id);
        }

        public List<Folder> GetFolders()
        {
            return new Folder().GetFolders();
        }

        public Guid GetGuidByName(string name)
        {
            return new Photo().GetGuidByName(name);
        }

        public Photo GetPhotoById(Guid id)
        {
            return new Photo().GetPhotoById(id);
        }

        public Photo GetPhotoByName(string name)
        {
            return new Photo().GetPhotoByName(name);
        }

        public List<Photo> GetPhotos()
        {
            return new Photo().GetPhotos();
        }

        public User GetUserById(Guid id)
        {
            return new User().GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return new User().GetUsers();
        }

        public Guid Login(string email, string password)
        {
            return new User().Login(email, password);
        }

        public void Register(string firstName, string lastName, string email, string password)
        {
            new User().Register(firstName, lastName, email, password);
        }

        public void UpdateFolder(Guid id, string name, string path, ICollection<Photo> photos)
        {
            new Folder().UpdateFolder(id, name, path, photos);
        }

        public void UpdatePhoto(Guid id, string name, string location, string description, string path, DateTime date, ICollection<Folder> folders)
        {
            new Photo().UpdatePhoto(id, name, location, description, path, date, folders);
        }

        public void UpdateUser(Guid id, string firstName, string lastName, string email, string password)
        {
            new User().UpdateUser(id, firstName, lastName, email, password);
        }
    }
}
