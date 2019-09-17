using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	/// <summary>
	/// Mức độ ưu tiên của thông báo
	/// </summary>
	public enum ĐộƯuTiên
	{
		Thấp,
		TrungBình,
		Cao
	}
	
	/// <summary>
	/// Thông báo tin tức - sự kiện
	/// </summary>
	public class ThongBao
	{
		public string TenTB { get; set; }
		public ĐộƯuTiên UuTien { get; set; }
		public DateTime NgayDang { get; set; }
		public DateTime NgayBD { get; set; }
		public DateTime NgayKT { get; set; }
		public string MoTa { get; set; }
	}
}
