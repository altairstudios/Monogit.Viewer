using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Monogit.WebViewer.Models;


namespace Monogit.Viewer.Web.Controllers {
	[HandleError]
	public class ProjectsController : Controller {
		public ActionResult Index() {
			return View();
		}
		
		
		public ActionResult Add() {
			return View();
		}
		
		
		public ActionResult AddProcess(string name, string path) {
			Project project = new Project();
			project.Name = name;
			project.Path = path;
			
			Monogit.Viewer.MvcApplication.projects.Add(project);
			
			return RedirectToAction("Index");
		}
		
		
		public ActionResult Viewer() {
			return View();
		}
	}
}