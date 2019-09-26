using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class LoadData
	{
		public static ICollection CreateDataSource()
		{
			DataTable table = new DataTable();
			DataRow row;
			table.Columns.Add(new DataColumn("STT", typeof(Int32)));
			table.Columns.Add(new DataColumn("MSSV", typeof(string)));
			table.Columns.Add(new DataColumn("HoVaTen", typeof(string)));
			table.Columns.Add(new DataColumn("NgaySinh", typeof(DateTime)));
			table.Columns.Add(new DataColumn("ChucNang", typeof(Nullable)));
			for (int i = 0; i < 9; i++)
			{
				row = table.NewRow();
				row[0] = i;
				row[1] = "100" + i.ToString();
				row[2] = "Some thing in int " + i.ToString();
				row[3] = DateTime.Now.AddDays(-i);
				row[4] = null;
				table.Rows.Add(row);
			}
			DataView dv = new DataView(table);
			return dv;
		}

	}
}
