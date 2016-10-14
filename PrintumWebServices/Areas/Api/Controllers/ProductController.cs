using PrintumWebServices.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintumWebServices.Areas.Api.Controllers
{
    public class ProductController : Controller
    {
        private ManagerProduct managerproducts;
        // GET: Api/Product
        public ProductController()
        {
            managerproducts = new ManagerProduct();
        }
        [HttpGet]
        public JsonResult ProductQuery()
        {
            return Json(managerproducts.values("101-05"), JsonRequestBehavior.AllowGet);
        }

    }
}
