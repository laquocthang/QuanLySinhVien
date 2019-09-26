using DataAccess;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace QuanLySinhVien.Pages
{
	public partial class Student : System.Web.UI.Page
	{
		private string sortExpression;
		private SortDirection sortDirection;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
				LoadStudentList();
			else
			{
				if (ViewState["SortExpression"] != null)
					sortExpression = ViewState["SortExpression"].ToString();
				else
					sortExpression = String.Empty;
				if (ViewState["SortDirection"] != null)
				{
					if (Convert.ToInt32(ViewState["SortDirection"]) == (int)SortDirection.Ascending)
						sortDirection = SortDirection.Ascending;
					else
						sortDirection = SortDirection.Descending;
				}
			}
		}

		private void LoadStudentList()
		{
			DataSet dsStudents = new DataSet();
			if (ViewState["StudentsDS"] != null)
				dsStudents = (DataSet)ViewState["StudentsDS"];
			else
			{
				dsStudents = LoadData.CreateDataSourceFromFile(Server.MapPath(@"Data\CTK43.csv"));
				ViewState["StudentsDS"] = dsStudents;
			}
			string sort = string.Empty;
			if (null != sortExpression && string.Empty != sortExpression)
				sort = string.Format("{0} {1}", sortExpression, (sortDirection == SortDirection.Descending) ? "DESC" : "ASC");
			DataView dataView = new DataView(dsStudents.Tables[0], string.Empty, sort, DataViewRowState.CurrentRows);
			grid_SinhVien.DataSource = dataView;
			grid_SinhVien.DataBind();
		}

		protected void grid_SinhVien_Sorting(object sender, GridViewSortEventArgs e)
		{
			if (string.Empty != sortExpression)
				if (string.Compare(e.SortExpression, sortExpression, true) == 0)
					sortDirection = (sortDirection == SortDirection.Ascending) ? SortDirection.Descending : SortDirection.Ascending;
				else
					sortDirection = SortDirection.Ascending;
			sortExpression = e.SortExpression;
			ViewState["SortExpression"] = e.SortExpression;
			ViewState["SortDirection"] = (int)sortDirection;
			LoadStudentList();
		}

		protected void grid_SinhVien_RowCreated(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.Header)
			{
				LinkButton btnSort;
				Image image;
				foreach (TableCell cell in e.Row.Cells)
				{
					if (cell.HasControls())
					{
						btnSort = (LinkButton)cell.Controls[0];
						image = new Image();
						image.Width = Unit.Parse("30px");
						if (ViewState["SortExpression"] != null)
							if (btnSort.CommandArgument == ViewState["SortExpression"].ToString())
							{
								if (Convert.ToInt32(ViewState["SortDirection"]) == (int)SortDirection.Ascending)
									image.ImageUrl = String.Format(@"data:image;base64,{0}", Properties.Resources.asc);
								else
									image.ImageUrl = String.Format(@"data:image;base64,{0}", Properties.Resources.desc);
								cell.Controls.Add(image);
							}
					}
				}
			}
		}
	}
}