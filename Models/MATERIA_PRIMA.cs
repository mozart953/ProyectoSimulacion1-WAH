namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MATERIA_PRIMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATERIA_PRIMA()
        {
            ELABORACIÓN_PRODUCTO = new HashSet<ELABORACIÓN_PRODUCTO>();
        }

        [Key]
        public int COD_MATERIA_PRIMA { get; set; }

        [Required]
        [StringLength(100)]
        public string NOMBRE_MATERIA_PRIMA { get; set; }

        public double PRECIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELABORACIÓN_PRODUCTO> ELABORACIÓN_PRODUCTO { get; set; }
    }
}
