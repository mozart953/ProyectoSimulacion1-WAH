namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENTAS_FUTURAS
    {
        [Key]
        public int COD_VENTA_FUTURA { get; set; }

        public int CANTIDAD_DESPACHADA { get; set; }

        public double PRECIO_TOTAL { get; set; }

        public int COD_PRODUCTO { get; set; }

        public double TIEMPO_UTILIZADO { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
