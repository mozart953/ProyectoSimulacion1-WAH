using ProyectoSimulacion1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProyectoSimulacion1.Controllers
{
    public class HomeController : Controller
    {
        private DETALLE_ESCENARIO escenario = new DETALLE_ESCENARIO();

        public ActionResult Index() {
            return View();

        }

       [HttpPost]
        public ActionResult Index(string p_horas, string p_clientes, string p_productos)
        {
            //Conexion con = new Conexion(p_horas, p_clientes, p_productos);
           /* int p_horas = Int32.Parse(p_horas1);
            int p_clientes = Int32.Parse(p_clientes1);
            int p_productos = Int32.Parse(p_productos1);*/

            //string p_horas1, string p_clientes1, string p_productos1
            /*int p_horas = Int32.Parse(p_horas1);
            int p_clientes = Int32.Parse(p_clientes1);
            int p_productos = Int32.Parse(p_productos1);*/
           // escenario.RealizarEscenario(p_horas, p_clientes, p_productos);

            if (escenario.RealizarEscenario(p_horas, p_clientes, p_productos))
            {
                ViewBag.alerta = "success";
                ViewBag.res = "Escenario creado correctamente";
                //return RedirectToAction("Index");
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "Algo salio mal, intentelo de nuevo";
            }
            //escenario.listar()

            return View();
        }
        
        public ActionResult About()
        {
          
            return View();
        }

        
        public ActionResult Contact()
        {
           

            return View();
        }
    }
}