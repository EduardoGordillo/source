using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDisposable
{
    class CPrueba : IDisposable
    {
        private Component component = new Component();
        int a;

        public CPrueba(int pA)
        {
            a = pA;
        }

        public void Dispose()
        {
           
        }

        public override string ToString()
        {
            return string.Format($"La variable es {a}");
        }

        
    }
}
