//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Culqi_Online.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comercio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comercio()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public int ID_Comercio { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> ID_Giro_Negn { get; set; }
        public string Llave_Publica { get; set; }
        public string Nombre_Comercio { get; set; }
        public string URL_Comercio { get; set; }
        public int celular { get; set; }
        public string Pais { get; set; }
        public string Terminos_condiicones { get; set; }
        public string Rubro { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
