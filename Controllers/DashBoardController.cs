using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoSimulacion1.DT_Reportes;
using ProyectoSimulacion1.Models;

namespace ProyectoSimulacion1.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ReporteTop()
        {
            DT objDT_Reporte = new DT();

            List<ReporteTopProducto> objLista = objDT_Reporte.RetornarTop();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReporteClientes()
        {
            DT objDT_Reporte = new DT();

            List<ReporteClientesProductos> objLista = objDT_Reporte.RetornarClientes();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult ReporteMas()
        {
            DT objDT_Reporte = new DT();

            List<ReporteMasVenta> objLista = objDT_Reporte.RetornarMasVenta();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReporteMenos()
        {
            DT objDT_Reporte = new DT();

            List<ReporteMenosVenta> objLista = objDT_Reporte.RetornarMenosVenta();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReporteGasto()
        {
            DT objDT_Reporte = new DT();

            List<ReporteGasto> objLista = objDT_Reporte.RetornarGasto();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }
    }
}