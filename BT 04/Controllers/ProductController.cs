using BT_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT_04.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string connectionstring = "Server=localhost;Database=QuanLySanPham;Integrated Security=True;";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionstring);
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}