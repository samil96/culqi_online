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
    
    public partial class Venta_Tarjeta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta_Tarjeta()
        {
            this.Medio_Pago = new HashSet<Medio_Pago>();
        }
    
        public int ID_Tarjeta { get; set; }
        public int ID_Estado_Tarjeta { get; set; }
        public Nullable<int> ID_Marca { get; set; }
        public int Num_tarjeta { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Estado_Tarjeta Estado_Tarjeta { get; set; }
        public virtual Marca Marca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medio_Pago> Medio_Pago { get; set; }
    }
}