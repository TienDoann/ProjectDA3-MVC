using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WebDoAnCuoiKi.Models;

namespace WebDoAnCuoiKi.Controllers
{
    public class ROGCatalogController : Controller
    {
        // GET: ROGCatalog
        public ActionResult Home()
        {
            ROGdataDataContext context = new ROGdataDataContext();
            List<ROGProduct> dsCatalog = context.ROGProducts.ToList();
            return View(dsCatalog);
        }
        public ActionResult DanhMuc()
        {
            ROGdataDataContext context = new ROGdataDataContext();
            List<ROGCatalog> dsCatalog = context.ROGCatalogs.ToList();
            return View(dsCatalog);
        }
        public ActionResult Xem(int id)
        {
            ROGdataDataContext context = new ROGdataDataContext();
            List<ROGProduct> sp = context.ROGProducts.Where(x => x.CatalogId == id).ToList();
            return View(sp);
        }
        public ActionResult Edit(int id)
        {
            ROGdataDataContext context = new ROGdataDataContext();
            ROGCatalog catalog = context.ROGCatalogs.FirstOrDefault(x => x.id == id);
            if (Request.Form.Count == 0)
            {
                return View(catalog);
            }
            string catalogCode = Request.Form["CatalogCode"];
            string catalogName = Request.Form["CatalogName"];
            catalog.CatalogCode = catalogCode;
            catalog.CatalogName = catalogName;
            context.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}