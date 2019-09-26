using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySinhVien.Pages
{
	public partial class Student : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
                cdcatalog.DataSource = CreateDataSource();
                cdcatalog.DataBind();
        }
        public ICollection CreateDataSource()
        {

            // Create sample data for the DataList control.
            DataTable dt = new DataTable();
            DataRow dr;

            // Define the columns of the table.
            dt.Columns.Add(new DataColumn("STT", typeof(Int32)));
            dt.Columns.Add(new DataColumn("MSSV", typeof(string)));
            dt.Columns.Add(new DataColumn("HoVaTen", typeof(string)));
            //dt.Columns.Add(new DataColumn("NgaySinh", typeof(DateTime)));
            //dt.Columns.Add(new DataColumn("ChucNang", typeof(Nullable)));

            // Populate the table with sample values.
            for (int i = 0; i < 9; i++)
            {
                dr = dt.NewRow();

                dr[0] = i;
                dr[1] = "100" + i.ToString();
                dr[2] = "Some thing in int " + i.ToString();
                //dr[3] = DateTime.Now.AddDays(-i);
                //dr[4] = null;
                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;
        }
    }
}