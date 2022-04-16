namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTOS()
        {
            ELABORACIÓN_PRODUCTO = new HashSet<ELABORACIÓN_PRODUCTO>();
            PRODUCTO_PERSONA = new HashSet<PRODUCTO_PERSONA>();
            VENTAS_INDIVIDUALES = new HashSet<VENTAS_INDIVIDUALES>();
            VENTAS_FUTURAS = new HashSet<VENTAS_FUTURAS>();
        }

        [Key]
        public int COD_PRODUCTO { get; set; }

        [Required]
        [StringLength(150)]
        public string NOMBRE_PRODUCTO { get; set; }

        public double PRECIO { get; set; }

        public double GANANCIA { get; set; }

        public double PRECIO_COSTO { get; set; }

        public double PRECIO_OPERATIVO { get; set; }

        public int? CANTIDAD_EXISTENTE { get; set; }

        public int? CANTIDAD_VENDIDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELABORACIÓN_PRODUCTO> ELABORACIÓN_PRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_PERSONA> PRODUCTO_PERSONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS_INDIVIDUALES> VENTAS_INDIVIDUALES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS_FUTURAS> VENTAS_FUTURAS { get; set; }
    }
}
