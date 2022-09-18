using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class HataController : Controller
    {
        // GET: Hata
        [HandleError(ExceptionType = typeof (FormatException),View = "Hata")]
        public ActionResult Index()
        {
            //return View();
           throw new FormatException();  // Projede herhangi bir hata olduğunda sayfada gösterir. Buda kötü bir görüntüye sebep olur.
        }
    }
}