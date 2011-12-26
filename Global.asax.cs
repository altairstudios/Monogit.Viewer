using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Monogit.WebViewer.Models;


namespace Monogit.Viewer {
	public class MvcApplication : System.Web.HttpApplication {
		
		public static string path = "";
		public static string diskPath = "";
		public static List<Project> projects = new List<Project>();
		
		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });
		}
		
		
		protected void Application_Start() {
			RegisterRoutes (RouteTable.Routes);
			
			MvcApplication.diskPath = HttpContext.Current.Server.MapPath("~");
            if(System.Web.HttpContext.Current.Request.ApplicationPath != "/") {
                    MvcApplication.path = System.Web.HttpContext.Current.Request.ApplicationPath;
            }
		}
	}
}