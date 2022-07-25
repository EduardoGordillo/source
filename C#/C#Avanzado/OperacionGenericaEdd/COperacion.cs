using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionGenericaEdd
{
    class COperacion<T>
    {
        public T suma(T a, T b)

        {
            dynamic da = a, db = b;
            return da + db;
        }
        public T resta(T a , T b)
        {
            dynamic da = a, db = b;
            return da - db;
        }

        public T div (T a, T b)
        {
            dynamic da = a, db = b;
            return da / db;

        }
        public T multi(T a , T b)
        {
            dynamic da = a, db = b;
            return da * db;
        }
    }
}
