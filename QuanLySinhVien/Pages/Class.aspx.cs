using DataAccess;
using System;
using System.Data;

namespace QuanLySinhVien.Pages
{
	public partial class Class : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
				LoadClassList();
		}

		private void LoadClassList()
		{
			DataTable dtClasses = (DataTable)LoadData.LoadClassListFromFile(Server.MapPath(@"Data\Classes.csv"));
			DataView dvClasses = new DataView(dtClasses);
			grid_LopHoc.DataSource = dvClasses;
			grid_LopHoc.DataBind();
		}
	}
}