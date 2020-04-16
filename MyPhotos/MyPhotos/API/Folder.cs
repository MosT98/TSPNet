using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public partial class Folder
    {

        public void UpdateFolder(Guid id, string name, string path, ICollection<Photo> photos)
        {
            Model1Container context = new Model1Container();
            var folder = context.Folders.FirstOrDefault(f => f.FolderId == id);
            folder.Name = name;
            folder.Path = path;
            folder.Photos = photos;
            context.SaveChanges();
        }

        public bool DeleteFolder(Guid id)
        {
            Model1Container context = new Model1Container();
            var folder = context.Folders.FirstOrDefault(f => f.FolderId == id);
            if (folder != default(Folder))
            {
                context.Folders.Remove(folder);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Folder> GetFolders()
        {
            Model1Container context = new Model1Container();
            var folders = context.Folders.ToList();
            return folders;
        }

        public Folder GetFolderById(Guid id)
        {
            Model1Container context = new Model1Container();
            var folder = context.Folders.FirstOrDefault(f => f.FolderId == id);
            if (folder != default(Folder))
            {
                return folder;
            }
            return null;
        }
    }
}
