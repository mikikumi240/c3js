using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class Mvc2TestController : Controller
    {
        // GET: Mvc2Test
        [Route("Mvctestp")]
        public ActionResult MyIndexp(int? id)
        {
            return View();
        }




        [Route("Mvctest")]
        public ActionResult MyIndex(int? id)
        {
            return View(); 
        }

        

    }
}