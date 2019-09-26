using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BinhLuan
    {
        public ConNguoi ChuBinhLuan { get; set; }
        public YKien YKien { get; set; }
        public string NoiDung { get; set; }

        public static BinhLuan Add(BinhLuan data)
        {
            return null;
        }
        public static bool Update(BinhLuan data)
        {
            return false;
        }
        public static bool Delete(BinhLuan data)
        {
            return false;
        }
    }
}
