using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	/// <summary>
	/// Trợ lý giáo vụ khoa
	/// </summary>
	public class TroLyGiaoVu : ConNguoi
	{

        public static int Add(TroLyGiaoVu data)
        {
            return 0;
        }
        public static bool Update(TroLyGiaoVu data)
        {
            return false;
        }
        public static bool Delete(TroLyGiaoVu data)
        {
            return false;
        }
        public static List<TroLyGiaoVu> GetAll()
        {
            return null;
        }
        public static List<TroLyGiaoVu> GetList(Condition condition)
        {
            return null;
        }
    }
}
