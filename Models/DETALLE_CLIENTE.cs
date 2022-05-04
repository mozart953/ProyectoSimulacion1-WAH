namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class DETALLE_CLIENTE
    {
        [Key]
        public int COD_DETALLE_CLIENTE { get; set; }

        public int CORRELATIVO_PRODUCTO { get; set; }

        public int COD_PRODUCTO { get; set; }

        public String NOMBRE_PRODUCTO { get; set; }

        public Double PRECIO { get; set; }

        public int COD_DETALLE_HORA { get; set; }

        public virtual DETALLE_HORA DETALLE_HORA { get; set; }

        //lista detalle cliente
        public List<DETALLE_CLIENTE> listar(int? dato)
        {
            string id = Convert.ToString(dato);
            var detCliente = new List<DETALLE_CLIENTE>();

            string consulta = "select * from dbo.DETALLE_CLIENTE where COD_DETALLE_HORA = " + id + ";";
            try
            {
                using (var contenedor = new Model3())
                {
                    detCliente = contenedor.Database.SqlQuery<DETALLE_CLIENTE>(consulta).ToList();
                }

            }
            catch (Exception)
            {

            }
            return detCliente;

        }


    }
}
