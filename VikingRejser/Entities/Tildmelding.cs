//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tildmelding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tildmelding()
        {
            this.Rejsearrangementers = new HashSet<Rejsearrangementer>();
        }
    
        public int Id { get; set; }
        public int Kunde { get; set; }
        public int Rejsearrangementer { get; set; }
    
        public virtual Kunder Kunder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rejsearrangementer> Rejsearrangementers { get; set; }
    }
}
