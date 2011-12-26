using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;


namespace Monogit.Viewer.Controllers {
	[HandleError]
	public class HomeController : Controller {
		public ActionResult Index () {
			return RedirectToAction("Index", "Projects");
		}
	}
}