using System;
using System.Collections.Generic;
using System.Linq;

namespace MetodosExtensionEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linq
            int?[] miArr = {1, null, 3, 4, null };
            var res = miArr.Sum(e => e);
            Console.WriteLine(res);
            #endregion
            #region Personalizado
            var coord = new List<int>() { 5, -9 };
            var inverso = coord.ObtenerInverso();
            Console.WriteLine($"{inverso.First()}, {inverso.Last()}");

            var nuevaCoord = coord.MoverCuadrante(3);
            Console.WriteLine($"{nuevaCoord.First()}, {nuevaCoord.Last()}");
            #endregion
        }
    }
}
