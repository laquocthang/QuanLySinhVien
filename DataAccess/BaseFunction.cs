using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    abstract class BaseFunction<T>
    {
        public abstract int Add(T item);
        public abstract bool Update(T item);
        public abstract bool Delete(T item);
        public abstract List<T> GetAll();
        public abstract List<T> GetList(Condition condition);
    }
}
