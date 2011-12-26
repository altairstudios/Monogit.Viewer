using System;


namespace Monogit.WebViewer.Models {
	public class Project {
		protected string name;
		protected string path;
		
		public string Name {
			get {
				return this.name;
			} set {
				this.name = value;	
			}
		}
		
		public string Path {
			get {
				return this.path;	
			} set {
				this.path = value;	
			}
		}
		
		public Project () {
		}
	}
}

