<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Viewer.master" %>
<asp:Content id="mainHolder" ContentPlaceHolderID="mainHolder" runat="server">
	<h1>New project</h1>
	<form method="post" action="AddProcess">
		<p>
			Name: <input type="text" name="name" />
		</p>
		<p>
			Path: <input type="text" name="path" />
		</p>
		<p>
			<input type="submit" value="Add" />
		</p>
	</form>
</asp:Content>