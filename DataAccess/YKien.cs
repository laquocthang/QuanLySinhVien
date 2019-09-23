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


        public static int Add(YKien data)
        {
            return 0;
        }
        public static bool Update(YKien data)
        {
            return false;
        }
        public static bool Delete(YKien data)
        {
            return false;
        }
        public static List<YKien> GetAll()
        {
            return null;
        }
        public static List<YKien> GetList(Condition condition)
        {
            return null;
        }
    }
}
