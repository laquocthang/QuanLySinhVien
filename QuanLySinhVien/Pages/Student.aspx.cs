using DataAccess;
using System;

namespace QuanLySinhVien.Pages
{
	public partial class Student : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
				LoadStudentList();
		}

		private void LoadStudentList()
		{
			grid_SinhVien.DataSource = LoadData.CreateDataSourceFromFile(Server.MapPath(@"Data\CTK43.csv"));
			grid_SinhVien.DataBind();
		}

	}
}