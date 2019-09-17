using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
