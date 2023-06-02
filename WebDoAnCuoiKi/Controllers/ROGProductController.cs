using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDoAnCuoiKi.Models;

namespace WebDoAnCuoiKi.Controllers
{
   
    public class ROGProductController : Controller
    {
        ROGdataDataContext context = new ROGdataDataContext();
        // GET: ROGProduct
        public ActionResult Index()
        {
            return View();
        }
        
    }
}