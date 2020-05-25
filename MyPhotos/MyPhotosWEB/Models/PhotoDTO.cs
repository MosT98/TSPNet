using System.ComponentModel.DataAnnotations;

namespace MyPhotosWEB.Models
{
    public class PhotoDTO
    {
        [Key]
        public System.Guid PhotoId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public System.DateTime Date { get; set; }
        public System.Guid UserUserId { get; set; }
    }
}
