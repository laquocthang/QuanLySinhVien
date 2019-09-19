using System;
using System.Web;
using System.Web.Routing;
using System.Web.UI;

namespace QuanLySinhVien
{
	public class Global : System.Web.HttpApplication
	{
		protected void RegisterRoutes(RouteCollection routes)
		{
			routes.MapPageRoute("route-homepage", "", "~/Pages/Index.aspx");
			routes.MapPageRoute("route-login", "Login", "~/Pages/Login.aspx");
			routes.MapPageRoute("route-activity", "Activity", "~/Pages/Activity.aspx");
			routes.MapPageRoute("route-class", "Class", "~/Pages/Class.aspx");
			routes.MapPageRoute("route-conduct", "Conduct", "~/Pages/Conduct.aspx");
			routes.MapPageRoute("route-discussion", "Discussion", "~/Pages/Discussion.aspx");
			routes.MapPageRoute("route-news", "News", "~/Pages/News.aspx");
			routes.MapPageRoute("route-resource", "Resource", "~/Pages/Resource.aspx");
			routes.MapPageRoute("route-student", "Student", "~/Pages/Student.aspx");
			routes.MapPageRoute("route-survey", "Survey", "~/Pages/Survey.aspx");
			routes.MapPageRoute("route-404", "404", "~/Pages/404.aspx");
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
			// Code that runs when an unhandled error occurs
			Exception ex = HttpContext.Current.Server.GetLastError();
			if (ex.InnerException != null)
			{
				ex = ex.InnerException;
			}
			if (ex is HttpException)
			{
				if (((HttpException)ex).GetHttpCode() == 404)
				{
					Response.Redirect("~/404");
				}
				else
				{
					Response.Redirect("/");
				}
			}

			HttpContext.Current.Server.ClearError();
		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}