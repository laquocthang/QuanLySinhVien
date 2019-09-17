using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
