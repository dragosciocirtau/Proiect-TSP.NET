using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;

    public partial class PictureDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PictureDTO()
        {
            this.People = new HashSet<PersonDTO>();
        }

        public int name { get; set; }
        public string type { get; set; }
        public string path { get; set; }
        public string creation_date { get; set; }
        public string location { get; set; }
        public string persons { get; set; }
        public string @event { get; set; }
        public string other_details { get; set; }

        public virtual EventDTO Event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDTO> People { get; set; }
        public virtual LocationDTO Location { get; set; }
    }
}
