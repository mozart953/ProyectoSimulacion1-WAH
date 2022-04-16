namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCTOS_TIEMPO
    {
        [Key]
        public int COD_PROD_TIEMPO { get; set; }

        public int CANTIDAD_PRODUCTOS { get; set; }

        public double PRECIO_TOTAL { get; set; }

        public int COD_HORARIO_ATENCION { get; set; }

        public virtual TIEMPO_ATENCION TIEMPO_ATENCION { get; set; }
    }
}
