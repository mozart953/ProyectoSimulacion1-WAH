namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIEMPO_ATENCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIEMPO_ATENCION()
        {
            PRODUCTOS_TIEMPO = new HashSet<PRODUCTOS_TIEMPO>();
            VENTAS_INDIVIDUALES = new HashSet<VENTAS_INDIVIDUALES>();
        }

        [Key]
        public int COD_HORARIO_ATENCION { get; set; }

        public TimeSpan? HORA_LLEGADA { get; set; }

        public TimeSpan? HORA_SALIDA { get; set; }

        public double TIEMPO_ENTRE_LLEGADAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOS_TIEMPO> PRODUCTOS_TIEMPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS_INDIVIDUALES> VENTAS_INDIVIDUALES { get; set; }
    }
}
