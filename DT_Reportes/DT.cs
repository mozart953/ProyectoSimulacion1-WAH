using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using ProyectoSimulacion1.Models;

namespace ProyectoSimulacion1.DT_Reportes
{
    public class DT
    {
        // Andres
        String c = "Data Source=DESKTOP-E80R7VG\\;Initial Catalog=DpanSimulacion;Integrated Security=True";

        // Wilson
        // String c = "Data Source = localhost; Initial Catalog = DpanSimulacion1; User ID = sa; Password = sa; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        //Yascal
        // String c = "Data Source=DESKTOP-M8SVI80\\SQLEXPRESS;Initial Catalog=DpanSimulacion;Integrated Security=True";


        public List<ReporteTopProducto> RetornarTop()
        {
            List<ReporteTopProducto> objLista = new List<ReporteTopProducto>();

            using (SqlConnection conexion = new SqlConnection(c))
            {
                string query = "SPR_TOP_PRODUCTOS";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteTopProducto()
                        {
                            PRODUCTO = dr["PRODUCTO"].ToString(),
                            CANTIDAD = int.Parse(dr["CANTIDAD"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }

        public List<ReporteClientesProductos> RetornarClientes()
        {
            List<ReporteClientesProductos> objLista = new List<ReporteClientesProductos>();

            using (SqlConnection conexion = new SqlConnection(c))
            {
                string query = "SPR_CLIENTES_PROUCTOS";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteClientesProductos()
                        {
                            CLIENTE = dr["CLIENTE"].ToString(),
                            CANTIDAD = int.Parse(dr["CANTIDAD"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }

        public List<ReporteMasVenta> RetornarMasVenta()
        {
            List<ReporteMasVenta> objLista = new List<ReporteMasVenta>();

            using (SqlConnection conexion = new SqlConnection(c))
            {
                string query = "SPR_CLIENTES_MAS_GASTO";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteMasVenta()
                        {
                            CLIENTE = dr["CLIENTE"].ToString(),
                            VENTA = float.Parse(dr["VENTA"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }

        public List<ReporteMenosVenta> RetornarMenosVenta()
        {
            List<ReporteMenosVenta> objLista = new List<ReporteMenosVenta>();

            using (SqlConnection conexion = new SqlConnection(c))
            {
                string query = "SPR_CLIENTES_MENOS_GASTO";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteMenosVenta()
                        {
                            CLIENTE = dr["CLIENTE"].ToString(),
                            VENTA = float.Parse(dr["VENTA"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }

        public List<ReporteGasto> RetornarGasto()
        {
            List<ReporteGasto> objLista = new List<ReporteGasto>();

            using (SqlConnection conexion = new SqlConnection(c))
            {
                string query = "SPR_GASTOS_VS_EMPRESA";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new ReporteGasto()
                        {
                            HORA = dr["HORA"].ToString(),
                            GANANCIA = float.Parse(dr["GANANCIA"].ToString()),
                            GASTO = float.Parse(dr["GASTO"].ToString()),
                        });
                    }
                }
            }

            return objLista;
        }
    }
}