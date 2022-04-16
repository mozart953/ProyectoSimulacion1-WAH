namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ELABORACIÓN_PRODUCTO
    {
        [Key]
        public int COD_ELABORACION { get; set; }

        public int COD_PRODUCTO { get; set; }

        public int COD_MATERIA_PRIMA { get; set; }

        public virtual MATERIA_PRIMA MATERIA_PRIMA { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
