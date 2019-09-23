using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Bí thư đoàn của khoa
    /// </summary>
    public class BiThuDoan : GiangVien
    {
        public static int Add(BiThuDoan data)
        {
            return 0;
        }
        public static bool Update(BiThuDoan data)
        {
            return false;
        }
        public static bool Delete(BiThuDoan data)
        {
            return false;
        }
        public static new List<BiThuDoan> GetAll()
        {
            return null;
        }
        public static new List<BiThuDoan> GetList(Condition condition)
        {
            return null;
        }
    }
}
