using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Lớp học
	/// </summary>
	public class LopHoc
	{
		public string MaLop { get; set; }
		public DateTime ThoiGianBD { get; set; } //Thời gian bắt đầu niên khoá
		public DateTime ThoiGianKT { get; set; } //Thời gian kết thúc niên khoá
		public GVCN GVCN { get; set; }
		public List<SinhVien> DanhSachSV { get; set; }

		public LopHoc()
		{

		}

		public LopHoc(string maLop, DateTime thoiGianBD, DateTime thoiGianKT, GVCN gVCN, List<SinhVien> danhSachSV)
		{
			MaLop = maLop;
			ThoiGianBD = thoiGianBD;
			ThoiGianKT = thoiGianKT;
			GVCN = gVCN;
			DanhSachSV = danhSachSV;
		}
	}
}
