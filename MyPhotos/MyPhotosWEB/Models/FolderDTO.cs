using System.ComponentModel.DataAnnotations;

namespace MyPhotosWEB.Models
{
    public class FolderDTO
    {
        [Key]
        public System.Guid FolderId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public System.Guid UserUserId { get; set; }
    }
}
