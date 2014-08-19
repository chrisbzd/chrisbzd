using Chrisbzd.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Chrisbzd.Controllers
{
    public abstract class ControllerBase<T> : System.Web.Mvc.Controller
    {
        public ActionResult Create()
        {
            return RedirectToAction("Details/0");
        }

        public ActionResult Delete(int id)
        {
            var db = new ChrisbzdEntities();
            var set = db.Set(typeof(T));
            var c = set.Find(id);
            set.Remove(c);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Details(T o)
        {
            ChrisbzdEntities db = new ChrisbzdEntities();
            var set = db.Set(typeof(T));
            if (this.IsNew(o))
            {
                set.Add(o);
            }
            else
            {
                db.Entry((object)o).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            var db = new ChrisbzdEntities();
            var set = db.Set(typeof(T));
            object o = null;
            if (id > 0)
            {
                o = set.Find(id);
            }
            else
            {
                o = set.Create();
            }
            return View(o);
        }

        public ActionResult Edit(int id)
        {
            return RedirectToAction("Details/" + id);
        }

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public abstract bool IsNew(object o);

        public ActionResult List()
        {
            var db = new ChrisbzdEntities();
            return View(db.Set(typeof(T)));
        }
    }
}