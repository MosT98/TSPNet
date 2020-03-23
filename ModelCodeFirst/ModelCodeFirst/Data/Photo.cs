using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelCodeFirst.Data
{
    public class Photo
    {
        [Key]
        public Guid PhotoId { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public String Path { get; set; }

        public Photo()
        {
            PhotoId = Guid.NewGuid();
        }
        public static Photo Create(String name, String location, String path)
        {
            return new Photo
            {
                PhotoId = Guid.NewGuid(),
                Name = name,
                Location = location,
                Path = path
            };
        }
    }
}
