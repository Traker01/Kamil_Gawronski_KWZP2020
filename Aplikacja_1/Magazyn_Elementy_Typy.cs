//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacja_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Magazyn_Elementy_Typy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Magazyn_Elementy_Typy()
        {
            this.Magazyn_Elementy = new HashSet<Magazyn_Elementy>();
        }
    
        public int ID_Element_Typ { get; set; }
        public string Typ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Magazyn_Elementy> Magazyn_Elementy { get; set; }
    }
}
