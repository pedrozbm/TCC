//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inseminacoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inseminacoes()
        {
            this.Diagnostico_Pos = new HashSet<Diagnostico_Pos>();
            this.Diagnostico_Pre = new HashSet<Diagnostico_Pre>();
        }
    
        public int ID_Inseminacao { get; set; }
        public Nullable<int> ID_Animal { get; set; }
        public Nullable<System.DateTime> Data_Inseminacao { get; set; }
        public string Metodo_Inseminacao { get; set; }
        public Nullable<int> ID_Inseminador { get; set; }
        public string Observacoes { get; set; }
    
        public virtual Animais Animais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostico_Pos> Diagnostico_Pos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostico_Pre> Diagnostico_Pre { get; set; }
        public virtual Inseminadores Inseminadores { get; set; }
    }
}
