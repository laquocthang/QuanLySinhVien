using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    class QuanLySinhVien : BaseFunction<SinhVien>
    {
        public override int Add(SinhVien data)
        {
            return 0;
        }
        public override bool Update(SinhVien data)
        {
            return false;
        }
        public override bool Delete(SinhVien data)
        {
            return false;
        }
        public static List<SinhVien> GetAll()
        {
            return null;
        }
        public static List<SinhVien> GetList(Condition condition)
        {
            return null;
        }
    }
}
