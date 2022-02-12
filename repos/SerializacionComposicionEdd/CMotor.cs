using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionComposicionEdd
{
    [Serializable]
    class CMotor
    {
        private int cilindros;
        private int hp;

        public int Cilindros { set { cilindros = value; } get { return cilindros; } }
        public int Hp { set { hp = value; } get { return hp; } }

        public CMotor()
        {
            cilindros = 4;
            hp = 200;
        }
        public void MuestraMotor()
        {
            Console.WriteLine($"=== Cilindros: {cilindros}\n" +
                $" Hp: {hp}");
        }
    }

}
