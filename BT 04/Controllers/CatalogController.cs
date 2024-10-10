using BT_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT_04.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            string connectionstring = "Server=localhost;Database=QuanLySanPham;Integrated Security=True;";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionstring);
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}