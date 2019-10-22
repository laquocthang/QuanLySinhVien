using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	/// <summary>
	/// Giáo viên chủ nhiệm
	/// </summary>
	public class GVCN : GiangVien
	{
		public List<LopHoc> LopCN { get; set; }


        public static int Add(GVCN data)
        {
            return 0;
        }
        public static bool Update(GVCN data)
        {
            return false;
        }
        public static bool Delete(GVCN data)
        {
            return false;
        }
        public static new List<GVCN> GetAll()
        {
            return null;
        }
        public static new List<GVCN> GetList(Condition condition)
        {
            return null;
        }
    }
}
