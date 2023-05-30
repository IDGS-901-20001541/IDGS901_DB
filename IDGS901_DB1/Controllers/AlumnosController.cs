using IDGS901_DB1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_DB1.Controllers
{
    public class AlumnosController : Controller
    {
        public ActionResult Index()
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                return View(dbAlumnos.Alumnos.ToList());
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Alumnos alumn)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                dbAlumnos.Alumnos.Add(alumn);
                dbAlumnos.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
