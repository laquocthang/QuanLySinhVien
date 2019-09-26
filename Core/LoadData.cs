using System;
using System.Collections;
using System.Data;
using System.IO;

namespace DataAccess
{
	public class LoadData
	{
		public static DataSet CreateDataSourceFromFile(string path)
		{
			DataTable table = new DataTable();
			DataRow row;
			table.Columns.Add(new DataColumn("STT", typeof(Int32)));
			table.Columns.Add(new DataColumn("MSSV", typeof(string)));
			table.Columns.Add(new DataColumn("Ho", typeof(string)));
			table.Columns.Add(new DataColumn("Ten", typeof(string)));
			table.Columns.Add(new DataColumn("NgaySinh", typeof(string)));
			table.Columns.Add(new DataColumn("ThaoTac", typeof(string)));
			using (var reader = new StreamReader(path))
			{
				int index = 1;
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
			DataSet data = new DataSet();
			data.Tables.Add(table);
			return data;
		}

	}
}
