//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelAndAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Picture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Picture()
        {
            this.People = new HashSet<Person>();
        }
    
        public int Id { get; set; }
        public string type { get; set; }
        public string path { get; set; }
        public string creation_date { get; set; }
        public string location { get; set; }
        public string persons { get; set; }
        public string @event { get; set; }
        public string other_details { get; set; }
    
        public virtual Event Event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
        public virtual Location Location { get; set; }
    }
}
