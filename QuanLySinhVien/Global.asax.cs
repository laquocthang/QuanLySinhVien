using System;
using System.Web.Routing;

namespace QuanLySinhVien
{
	public class Global : System.Web.HttpApplication
	{
		protected void RegisterRoutes(RouteCollection routes)
		{
			routes.MapPageRoute("route-login", "Login", "~/Pages/Login.aspx");
			routes.MapPageRoute("route-homepage", "", "~/Pages/Index.aspx");
		}

		protected void Application_Start(object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}