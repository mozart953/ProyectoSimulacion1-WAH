namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCTO_PERSONA
    {
        [Key]
        public int COD_PRODUCTO_PERSONA { get; set; }

        public int COD_TOTAL_VENTA { get; set; }

        public int COD_PRODUCTO { get; set; }

        public double TOTAL_VENTA { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }

        public virtual TOTAL_VENTAS_FUTURAS TOTAL_VENTAS_FUTURAS { get; set; }
    }
}
