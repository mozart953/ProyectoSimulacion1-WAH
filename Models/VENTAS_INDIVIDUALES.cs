namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENTAS_INDIVIDUALES
    {
        [Key]
        public int COD_VENTA_ACTUAL { get; set; }

        public int COD_HORARIO_ATENCION { get; set; }

        public int COD_PRODUCTO { get; set; }

        public int CANTIDAD_DESPACHADA { get; set; }

        public double PRECIO_TOTAL { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }

        public virtual TIEMPO_ATENCION TIEMPO_ATENCION { get; set; }
    }
}
