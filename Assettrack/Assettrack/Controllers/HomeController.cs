using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assettrack.Models;
using System.Data;

namespace Assettrack.Controllers
{
    public class HomeController : Controller
    {
        private DBAssetEntities db = new DBAssetEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard(string name)
        {
            int ptr=0;
            if (name== "PALAMPUR/HP/IN")
            { ptr = 1; }
            else if(name == "HAZARIBAUGH/JR/IN")
            { ptr = 2; }
            else if (name == "PALAKKAD/KR/IN")
            { ptr = 3; }
            else if (name == "JALGAON/MH/IN")
            { ptr = 4; }
            else if (name == "PATNA/BR/IN")
            { ptr = 5; }
            else if (name == "KUTCH/GJ/IN")
            { ptr = 6; }

            ViewBag.id = ptr;
            Asset_Data ad = db.Asset_Data.Where(m => m.asset_id == name).OrderByDescending(n => n.id).First();
            var adlist = db.Asset_Data.Where(m => m.asset_id == name).OrderByDescending(n => n.id).Take(5);
            ModelProperties mp = new ModelProperties { Asset_Data_Iqueryable = adlist, Asset_Data_Object = ad };
            return View(mp);
            
            
        }
    }
}