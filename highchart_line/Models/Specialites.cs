//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace highchart_line.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specialites
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialites()
        {
            this.MedecinConventionnes = new HashSet<MedecinConventionnes>();
        }
    
        public int IdSpecialite { get; set; }
        public string SpecialiteName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedecinConventionnes> MedecinConventionnes { get; set; }
    }
}