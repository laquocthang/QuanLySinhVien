using System;
using System.Collections;
using System.Data;
using System.IO;

namespace DataAccess
{
	public class LoadData
	{
		public static ICollection CreateDataSourceFromFile(string path)
		{
			DataTable table = new DataTable();
			DataRow row;
			table.Columns.Add(new DataColumn("STT", typeof(Int32)));
			table.Columns.Add(new DataColumn("MSSV", typeof(string)));
			table.Columns.Add(new DataColumn("Họ", typeof(string)));
			table.Columns.Add(new DataColumn("Tên", typeof(string)));
			table.Columns.Add(new DataColumn("Ngày Sinh", typeof(string)));
			table.Columns.Add(new DataColumn("Thao Tác", typeof(string)));
			using (var reader = new StreamReader(path))
			{
				int index = 0;
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(',');
					row = table.NewRow();
					row[0] = index;     //STT
					row[1] = values[0]; //MSSV
					row[2] = values[1]; //Ho
					row[3] = values[2]; //Ten
					row[4] = values[3]; //NgaySinh
					row[5] = "";        //Chua co gi het!
					table.Rows.Add(row);
					index++;
				}
			}
			DataView view = new DataView(table);
			return view;
		}

	}
}
