using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Ý kiến thảo luận
	/// </summary>
	public class YKien
	{
		public string TenYKien { get; set; }
		public string MoTa { get; set; }
		public bool DuocDuyet { get; set; } //Ý kiến đã được duyệt để hiển thị
		public List<ConNguoi> TanThanh { get; set; } //Người tán thành
		public List<ConNguoi> KhongTanThanh { get; set; } //Người không tán thành
		public bool DuocXemXet { get; set; } //Ý kiến được xem xét cấp khoa

		public YKien()
		{

		}

		public YKien(string tenYKien, string moTa, bool duocDuyet, List<ConNguoi> tanThanh, List<ConNguoi> khongTanThanh, bool duocXemXet)
		{
			TenYKien = tenYKien;
			MoTa = moTa;
			DuocDuyet = duocDuyet;
			TanThanh = tanThanh;
			KhongTanThanh = khongTanThanh;
			DuocXemXet = duocXemXet;
		}
	}
}
