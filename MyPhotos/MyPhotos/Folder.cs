//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class Folder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Folder()
        {
            this.Photos = new HashSet<Photo>();
        }

        [DataMember]
        public System.Guid FolderId { get; set; }
        
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public System.Guid UserUserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Photo> Photos { get; set; }
        [DataMember]
        public virtual User User { get; set; }
    }
}