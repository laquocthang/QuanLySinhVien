using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess
{
    public abstract class DataAccessControls
    {
        public virtual object[] ToListObjects()
        {
            List<object> temp = new List<object>();
            foreach (var item in this.GetType().GetProperties().OrderBy(s => s.MetadataToken))
            {
                temp.Add(item.GetValue(this, null));
            }
            return temp.ToArray();
        }
        public static bool Update(DataAccessControls data)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery(data.GetType().Name+"_Update", data.ToListObjects());
            return rs > 0;
        }
        public static bool Delete(DataAccessControls data)
        {
            return false;
        }
    }
}
