using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;


namespace Monogit.Viewer.Controllers {
	[HandleError]
	public class ProjectsController : Controller {
		public ActionResult Index () {
			return View();
		}
	}
}