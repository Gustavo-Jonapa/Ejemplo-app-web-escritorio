using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNACH.Alumnos.Sitio100019241.Models;

namespace UNACH.Alumnos.Sitio100019241.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult datosalumnos()
        {
            using (BdEscuelaModel context=new BdEscuelaModel())
            {
                var listaAlumnos=context.Alumnos.ToList();
                return View(listaAlumnos);
            }
                
        }
        public ActionResult Edit(int id)
        {
            using (BdEscuelaModel _context = new BdEscuelaModel())
            {
                var _alumno = _context.Alumnos.Find(id);
                    if (_alumno == null)
                {
                    return NoEncontrado();
                }
                return View(_alumno);
            }
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Alumno alumno)
        {
            using (BdEscuelaModel _context = new BdEscuelaModel())
            {
                if (!ModelState.IsValid)
                {
                    return View(alumno);
                }
                var _alumno = (from c in _context.Alumnos where c.id == alumno.id select c).FirstOrDefault();
                if (_alumno != null)
                {
                    _alumno.Nombre = alumno.Nombre;
                    _alumno.Correo = alumno.Correo;
                    _alumno.Telefono = alumno.Telefono;
                }

                _context.SaveChanges();
                return RedirectToAction(nameof(datosalumnos));
            }
        }
        private ActionResult NoEncontrado()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            using (BdEscuelaModel _context = new BdEscuelaModel())
            {
                var _alumno = _context.Alumnos.Find(id);
                if (_alumno == null)
                {
                    return NoEncontrado();
                }
                return View(_alumno);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Alumno alumno)
        {
            using (BdEscuelaModel _context = new BdEscuelaModel())
            {
                var _alumno = _context.Alumnos.Find(id);
                if (_alumno != null)
                {
                    _context.Alumnos.Remove(_alumno);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(datosalumnos));
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno alumno)
        {
            using (BdEscuelaModel _context = new BdEscuelaModel())
            {
                if (!ModelState.IsValid)
                {
                    return View(alumno);
                }
                alumno.FechaRegistro = DateTime.Now;
                _context.Alumnos.Add(alumno);
                _context.SaveChanges();
                return RedirectToAction(nameof(datosalumnos));
            }
        }
        public ActionResult Details(int id)
        {
            using (BdEscuelaModel _context = new BdEscuelaModel())
            {
                var _alumno = _context.Alumnos.Find(id);
                if (_alumno == null)
                {
                    return NoEncontrado();
                }
                return View(_alumno);
            }
        }
    }
}