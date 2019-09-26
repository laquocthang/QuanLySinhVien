using DataAccess;
using System;

namespace QuanLySinhVien.Pages
{
	public partial class Student : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadStudentList();
		}

		private void LoadStudentList()
		{
			tbl_SinhVien.DataSource = LoadData.CreateDataSource();
			tbl_SinhVien.DataBind();
		}

	}
}