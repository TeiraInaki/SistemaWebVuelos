using SistemaWebVuelos.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SistemaWebVuelos.Models;
using System.Data.Entity;

namespace SistemaWebVuelos.Controllers
{
    [FiltroDeAccion]
    public class VueloController : Controller
    {
        private VueloDbContext context = new VueloDbContext();

        //Index

        // GET: Vuelo
        public ActionResult Index()
        {
            var vuelos = context.Vuelos.ToList();

            return View("Index", vuelos);
        }

        //Index Por Destino

        public ActionResult IndexPorDestino(string destino)
        {
            if (destino == "")
            {
                return RedirectToAction("Index");
            }

            var vuelos = (from v in context.Vuelos where v.Destino == destino select v).ToList();

            return View("Index", vuelos);
        }

        //Crear

        public ActionResult Create()
        {
            Vuelo vuelo = new Vuelo();
            return View("Create", vuelo);
        }

        [HttpPost]
        public ActionResult Create(Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                context.Vuelos.Add(vuelo);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Create", vuelo);
        }

        //Detail

        public ActionResult Detail(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            if (vuelo != null)
            {
                return View("Detail", vuelo);
            }
            else return HttpNotFound();
        }

        //Delete

        public ActionResult Delete(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            if (vuelo != null)
            {
                return View("Delete", vuelo);
            }
            else return HttpNotFound();
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            context.Vuelos.Remove(vuelo);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        
        //Edit

        public ActionResult Edit(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            if (vuelo != null)
            {
                return View("Edit", vuelo);
            }
            else return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                context.Entry(vuelo).State = EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else return View("Edit", vuelo);
        }
    }
}