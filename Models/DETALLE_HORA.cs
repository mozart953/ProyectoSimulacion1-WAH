namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class DETALLE_HORA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DETALLE_HORA()
        {
            DETALLE_CLIENTE = new HashSet<DETALLE_CLIENTE>();
        }

        [Key]
        public int COD_DETALLE_HORA { get; set; }

        public int CORRELATIVO_CLIENTE { get; set; }

        public int? CANTIDAD_PRODUCTOS { get; set; }

        public double? TOTAL_VENTA { get; set; }

        public int COD_DETALLE_ESCENARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_CLIENTE> DETALLE_CLIENTE { get; set; }



        public List<DETALLE_HORA> listar(int? dato)
        {
            string id = Convert.ToString(dato);
            var detHora = new List<DETALLE_HORA>();

            string consulta = "select * from dbo.DETALLE_HORA where COD_DETALLE_ESCENARIO = "+ id+";";
            try
            {
                using (var contenedor = new Model3())
                {
                    detHora = contenedor.Database.SqlQuery<DETALLE_HORA>(consulta).ToList();
                }

            }
            catch (Exception)
            {

            }
            return detHora;

        }
    }
}
