﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionComposicionEdd
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;
        private CMotor motor;

        public double Costo { set { costo = value; } get { return costo; } }
        public string Modelo { set { modelo = value; } get { return modelo; } }

        public CMotor Motor { set { motor = value; } }

        public CAuto()
        {
            costo = 100000;
            modelo = "Cupra";
            motor = new CMotor();
        }

        public void MuestraAuto()
        {
            Console.WriteLine("-----------");
            Console.WriteLine($"El auto es {modelo}\n" +
                $"Costo : {costo}");
            motor.MuestraMotor();
            Console.WriteLine("-------------");
        }
    }
}
