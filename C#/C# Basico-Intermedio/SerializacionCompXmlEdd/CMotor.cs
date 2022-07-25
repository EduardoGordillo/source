using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionCompXmlEdd
{
    [Serializable]
    public class CMotor
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
        public CMotor(int pCilindros, int pHp)
        {
            cilindros = pCilindros;
            hp = pHp;
        }

        public void MuestraMotor()
        {
            Console.WriteLine($"=== Cilindros: {cilindros}\n" +
                $" Hp: {hp}");
        }
    }

}
