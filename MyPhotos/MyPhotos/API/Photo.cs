using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public partial class Photo
    {
        public Photo GetPhotoById(Guid id)
        {
            Model1Container context = new Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.PhotoId == id);
            if (photo != default(Photo))
            {
                return photo;
            }
            return null;
        }

        public Photo GetPhotoByName(string name)
        {
            Model1Container context = new Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.Name == name);
            return photo;
        }

        public Guid GetGuidByName(string name)
        {
            Model1Container context = new Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.Name == name);
            return photo.PhotoId;
        }

        public List<Photo> GetPhotos()
        {
            Model1Container context = new Model1Container();
            var photos = context.Photos.ToList();
            return photos;
        }

        public bool DeletePhoto(Guid id)
        {
            Model1Container context = new Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.PhotoId == id);
            if (photo != default(Photo))
            {
                context.Photos.Remove(photo);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public void UpdatePhoto(Guid id, string name, string location, string description, string path, DateTime date, ICollection<Folder> folders)
        {
            Model1Container context = new Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.PhotoId == id);
            photo.Name = name;
            photo.Location = location;
            photo.Description = description;
            photo.Path = path;
            photo.Date = date;
            photo.Folders = folders;
            context.SaveChanges();
        }

        public void AddPhoto(string name, string location, string description, string path, DateTime date, Guid idUser)
        {
            Model1Container context = new Model1Container();
            var photo = Photo.CreatePhoto(name, location, description, path, date, idUser);
            context.Photos.Add(photo);
            context.SaveChanges();
        }
    }
}
