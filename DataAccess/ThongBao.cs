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


        public static int Add(ThongBao data)
        {
            return 0;
        }
        public static bool Update(ThongBao data)
        {
            return false;
        }
        public static bool Delete(ThongBao data)
        {
            return false;
        }
        public static List<ThongBao> GetAll()
        {
            return null;
        }
        public static List<ThongBao> GetList(Condition condition)
        {
            return null;
        }
    }
}
