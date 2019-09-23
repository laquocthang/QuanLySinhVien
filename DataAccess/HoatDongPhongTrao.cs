using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	/// <summary>
	/// Hoạt động phong trào
	/// </summary>
	public class HoatDongPhongTrao
    {
		public string TenHD { get; set; }
		public string MoTa { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }

        public static int Add(HoatDongPhongTrao data)
        {
            return 0;
        }
        public static bool Update(HoatDongPhongTrao data)
        {
            return false;
        }
        public static bool Delete(HoatDongPhongTrao data)
        {
            return false;
        }
        public static List<HoatDongPhongTrao> GetAll()
        {
            return null;
        }
        public static List<HoatDongPhongTrao> GetList(Condition condition)
        {
            return null;
        }
    }
}
