namespace ProyectoSimulacion1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class DETALLE_ESCENARIO
    {
        [Key]
        public int COD_DETALLE_ESCENARIO { get; set; }

        public int CORRELATIVO_HORA { get; set; }

        public int? TOTAL_PERSONAS { get; set; }

        public int? CANTIDAD_PRODUCTOS { get; set; }

        public double? TOTAL_VENTAS { get; set; }



        //Listar escenarios
        public List<DETALLE_ESCENARIO> listar() {
            var escenarios = new List<DETALLE_ESCENARIO>();

            string consulta = "SELECT * FROM DETALLE_ESCENARIO;";
            try
            {
                using (var contenedor = new Model2()) {
                    escenarios = contenedor.Database.SqlQuery<DETALLE_ESCENARIO>(consulta).ToList();
                }

            }
            catch (Exception) { 
            
            }
            return escenarios;
        
        }



        //METODO PARA ACTIVAR EL PROCEDIMIENTO

        public Boolean RealizarEscenario(string p_horas, string p_clientes, string p_productos) {
            bool estado = false;
            try
            {

                using (var conexion = new Model2()) {
                    int consulta = conexion.Database.ExecuteSqlCommand("EXEC CRT_ESCENARIO @p_HORAS= " + p_horas+
                        ", @p_CLIENTES= "+p_clientes+", @p_PRODUCTOS= " + p_productos+";");
                    estado = true;

                    if (consulta == 1) {
                        estado = true;
                    }
                }
            }
            catch(Exception) {

                estado = false;
            }

            return estado;
        
        }


    }
}
