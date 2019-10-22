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


        public static int Add(LopHoc data)
        {
            return 0;
        }
        public static bool Update(LopHoc data)
        {
            return false;
        }
        public static bool Delete(LopHoc data)
        {
            return false;
        }
        public static List<LopHoc> GetAll()
        {
            return null;
        }
        public static List<LopHoc> GetList(Condition condition)
        {
            return null;
        }
    }
}
