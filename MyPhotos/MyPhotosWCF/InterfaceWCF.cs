using MyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosWCF
{
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        Photo GetPhotoById(Guid id);
        [OperationContract]
        Photo GetPhotoByName(string name);
        [OperationContract]
        Guid GetGuidByName(string name);
        [OperationContract]
        List<Photo> GetPhotos();
        [OperationContract]
        bool DeletePhoto(Guid id);
        [OperationContract]
        void UpdatePhoto(Guid id, string name, string location, string description, string path, DateTime date, ICollection<Folder> folders);
        [OperationContract]
        void AddPhoto(string name, string location, string description, string path, DateTime date, Guid idUser);

    }
    [ServiceContract]
    interface InterfaceUser
    {
        [OperationContract]
        User GetUserById(Guid id);
        [OperationContract]
        List<User> GetUsers();
        [OperationContract]
        bool DeleteUser(Guid id);
        [OperationContract]
        void UpdateUser(Guid id, string firstName, string lastName, string email, string password);
        [OperationContract]
        void Register(string firstName, string lastName, string email, string password);
        [OperationContract]
        Guid Login(string email, string password);
    }
    [ServiceContract]
    interface InterfaceFolder
    {
        [OperationContract]
        void UpdateFolder(Guid id, string name, string path, ICollection<Photo> photos);
        [OperationContract]
        bool DeleteFolder(Guid id);
        [OperationContract]
        List<Folder> GetFolders();
        [OperationContract]
        Folder GetFolderById(Guid id);
    }
    [ServiceContract]
    interface IMyPhotos: InterfaceFolder, InterfacePhoto, InterfaceUser
    {
    }
}
