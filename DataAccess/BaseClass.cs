using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess
{
    public abstract class BaseClass
    {

        public virtual object[] ToListObjects()
        {
            List<object> temp = new List<object>();
            foreach (var item in this.GetType().GetProperties().OrderBy(s=>s.MetadataToken))
            {
                temp.Add(item.GetValue(this, null));
            }
            return temp.ToArray();
        }
        public static int Add(BaseClass data)
        {

            return 0;
        }
        public virtual bool Update(BaseClass data)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery(this.GetType().Name+"_Update",data.ToListObjects());
            return rs > 0;
        }
        public virtual bool Delete(string postId)
        {
            try
            {
                int rs = DataProvider.Instance.ExecuteNonQuery("Post_Delete",
                Convert.ToInt32(postId));
                return rs > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
