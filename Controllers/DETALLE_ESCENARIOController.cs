using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoSimulacion1.Models;

namespace ProyectoSimulacion1.Controllers
{
    public class DETALLE_ESCENARIOController : Controller
    {
        private Model2 db = new Model2();
        //private Model3 db2 = new Model3();
        DETALLE_HORA db2 = new DETALLE_HORA();
        DETALLE_CLIENTE db3 = new DETALLE_CLIENTE();

        // GET: DETALLE_ESCENARIO
        public ActionResult Index()
        {
            return View(db.DETALLE_ESCENARIO.ToList());
        }

        // GET: DETALLE_ESCENARIO/Details/5 detalle de hora
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            /*DETALLE_ESCENARIO dETALLE_ESCENARIO = db.DETALLE_ESCENARIO.Find(id);
            
            if (dETALLE_ESCENARIO == null)
            {
                return HttpNotFound();
            }*/
           


            return View(db2.listar(id));
        }

        // GET: DETALLE_ESCENARIO/Detalle2/5 para el detalle de cliente
        public ActionResult Detalle2(int? id) {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(db3.listar(id));
        
        }

        // GET: DETALLE_ESCENARIO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DETALLE_ESCENARIO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_DETALLE_ESCENARIO,CORRELATIVO_HORA,TOTAL_PERSONAS,CANTIDAD_PRODUCTOS,TOTAL_VENTAS")] DETALLE_ESCENARIO dETALLE_ESCENARIO)
        {
            if (ModelState.IsValid)
            {
                db.DETALLE_ESCENARIO.Add(dETALLE_ESCENARIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dETALLE_ESCENARIO);
        }

        // GET: DETALLE_ESCENARIO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DETALLE_ESCENARIO dETALLE_ESCENARIO = db.DETALLE_ESCENARIO.Find(id);
            if (dETALLE_ESCENARIO == null)
            {
                return HttpNotFound();
            }
            return View(dETALLE_ESCENARIO);
        }

        // POST: DETALLE_ESCENARIO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_DETALLE_ESCENARIO,CORRELATIVO_HORA,TOTAL_PERSONAS,CANTIDAD_PRODUCTOS,TOTAL_VENTAS")] DETALLE_ESCENARIO dETALLE_ESCENARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dETALLE_ESCENARIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dETALLE_ESCENARIO);
        }

        // GET: DETALLE_ESCENARIO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DETALLE_ESCENARIO dETALLE_ESCENARIO = db.DETALLE_ESCENARIO.Find(id);
            if (dETALLE_ESCENARIO == null)
            {
                return HttpNotFound();
            }
            return View(dETALLE_ESCENARIO);
        }

        // POST: DETALLE_ESCENARIO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DETALLE_ESCENARIO dETALLE_ESCENARIO = db.DETALLE_ESCENARIO.Find(id);
            db.DETALLE_ESCENARIO.Remove(dETALLE_ESCENARIO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
