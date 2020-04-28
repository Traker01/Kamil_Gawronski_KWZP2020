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
    
    public partial class Magazyn_Elementy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Magazyn_Elementy()
        {
            this.Czesci_Obsluga = new HashSet<Czesci_Obsluga>();
            this.Elementy_Proces = new HashSet<Elementy_Proces>();
            this.Koszt_Jednostkowy = new HashSet<Koszt_Jednostkowy>();
            this.Magazyn_Oferta = new HashSet<Magazyn_Oferta>();
            this.Material_Na_Produkcji = new HashSet<Material_Na_Produkcji>();
            this.Zamowienie_Produkt = new HashSet<Zamowienie_Produkt>();
            this.Zapotrzebowanie_Opakowan = new HashSet<Zapotrzebowanie_Opakowan>();
        }
    
        public int ID_Element { get; set; }
        public Nullable<int> ID_Element_Typ { get; set; }
        public string Element_Nazwa { get; set; }
        public string Element_Oznaczenie { get; set; }
        public Nullable<int> Okres_Przydatnosci_Miesiace { get; set; }
        public Nullable<float> Element_Ilosc_W_Paczce { get; set; }
        public Nullable<int> ID_Jednostka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czesci_Obsluga> Czesci_Obsluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elementy_Proces> Elementy_Proces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Koszt_Jednostkowy> Koszt_Jednostkowy { get; set; }
        public virtual Magazyn_Elementy_Typy Magazyn_Elementy_Typy { get; set; }
        public virtual Magazyn_Elementy_Jednostki Magazyn_Elementy_Jednostki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Magazyn_Oferta> Magazyn_Oferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Na_Produkcji> Material_Na_Produkcji { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie_Produkt> Zamowienie_Produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapotrzebowanie_Opakowan> Zapotrzebowanie_Opakowan { get; set; }
    }
}
