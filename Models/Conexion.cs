using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ProyectoSimulacion1.Models
{
    public class Conexion
    {
        public Conexion(string p_horas, string p_clientes, string p_productos) {
            String sql = "EXEC CRT_ESCENARIO @p_HORAS=" +p_horas+ ",@p_CLIENTES =" +p_clientes + ", @p_PRODUCTOS =" +p_productos+";";
            //Conexion Wilson
            String cn = "Data Source = localhost; Initial Catalog = DpanSimulacion1; User ID = sa; Password = sa; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //Conexion Andres
            //String cn = "";
            DETALLE_ESCENARIO c = new DETALLE_ESCENARIO();
            
            try {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Model2"].ConnectionString))
                {
                    
                    using (SqlCommand comando = new SqlCommand(sql, cnn)) {
                        cnn.Open();
                        using (SqlDataReader lector = comando.ExecuteReader()) {
                            while (lector.Read())
                            {
                                //string a = lector.GetString(1);
                               // c.TOTAL_VENTAS = lector.GetDouble(4);
                                string b = "";
                                //Console.WriteLine("{0} {1}", lector.GetString(1), lector.GetString(2));
                            }
                        }
                    
                    }

                }
            }
            catch(Exception e) { 
            
            }
        }
    }
}