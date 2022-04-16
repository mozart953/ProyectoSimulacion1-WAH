namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOTAL_VENTAS_FUTURAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOTAL_VENTAS_FUTURAS()
        {
            PRODUCTO_PERSONA = new HashSet<PRODUCTO_PERSONA>();
        }

        [Key]
        public int COD_TOTAL_VENTA { get; set; }

        public int TOTAL_PERSONAS { get; set; }

        public int CANTIDAD_PRODUCTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_PERSONA> PRODUCTO_PERSONA { get; set; }
    }
}
