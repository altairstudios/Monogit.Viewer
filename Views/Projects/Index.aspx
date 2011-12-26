<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Viewer.master" %>
<asp:Content id="mainHolder" ContentPlaceHolderID="mainHolder" runat="server">
	<h1>Projects</h1>
	<table class="heads">
		<thead>
			<tr>
				<th>Name</th>
				<th>Path</th>
			</tr>
			<% for(int i = 0; i < Monogit.Viewer.MvcApplication.projects.Count; i++) { %>
			<tr>
				<td><a href="<%=Monogit.Viewer.MvcApplication.path%>/Projects/Viewer/<%=Monogit.Viewer.MvcApplication.projects[i].Name%>"><%=Monogit.Viewer.MvcApplication.projects[i].Name%></a></td>
				<td><%=Monogit.Viewer.MvcApplication.projects[i].Path%></td>
			</tr>
			<% } %>
		</thead>
		<tbody>
		</tbody>
	</table>
	<p>
		<a href="<%=Monogit.Viewer.MvcApplication.path%>/Projects/Add">Add project</a>
	</p>
</asp:Content>