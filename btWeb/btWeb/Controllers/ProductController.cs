using btWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        List<ProductModel> list = new List<ProductModel>
        {
            new ProductModel{ Id =  1, Name ="Quan", Price = 10},
            new ProductModel{ Id =  2, Name ="Ao", Price = 10}
        };
        public ActionResult Index()
        {
            return View(list);
        }

        public PartialViewResult getProduct()
        {
            return PartialView("getProduct", list);
        }

        [HttpPost]
        public JsonResult AddProduct(ProductModel newProduct)
        {
            newProduct.Id = list.Count + 1;
            list.Add(newProduct);
            return Json(new {success = true, Product = newProduct});
        }
    }
}