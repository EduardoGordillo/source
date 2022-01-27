using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprender
{
    class Program
    {
        static string empresa = "Temerarios";
        static void Main(string[] args)

        {
            cuenta(9);
             int  numero = nomreak(8); 
             string user1 = crearUsuario( "eduardo", "gordillo" );
             string user2 = crearUsuario("ivan", "gordillo");
             siEsto(60);

             Console.WriteLine(empresa +" - " + user1 + " - " + user2);

             static string  crearUsuario(string n, string a  )
             {

                 string nombre = n;
                 string apellido = a;
                 string nombreCompleto = nombre + " " + apellido;



                 Console.WriteLine(nombreCompleto.ToUpper());
                 bool casado = false;
                 casado = !casado;
                 Console.WriteLine(!casado);
                 DateTime fecha = DateTime.Today;
                 Console.WriteLine(fecha.ToLongDateString());
                 Console.WriteLine(fecha.AddDays(-1));
                 return (nombreCompleto);
             }

             static int nomreak(int i)
             {
                 int a;
                 for ( a = i ; i < 10; i++)
                     {
                     Console.WriteLine(a);

             }
                 int numb = a;
                 return (numb);
                     }
             ;


              static int siEsto(int edad)
             {
                 if (edad >= 18)
                 {
                     Console.WriteLine("Mayor de edad");
                 }
                 else
                 {
                     Console.WriteLine("Menor de edad");
                 }
                 if (edad < 5)
                 {
                     Console.WriteLine("Cursa kinder");
                 }
                 else if (edad > 60)
                 {
                     Console.WriteLine("Es un adulto mayor");
                 }
                 else
                 {
                     Console.WriteLine("Adulto promedio");
                 }
                 return 0;
             }
            static void cuenta(int numero)
            {
                Console.WriteLine(numero);
                if (numero > 0)
                {
                    cuenta(numero - 1);
                }
            }
        

            /*string user1 = "juan";

            string user2 = "pedro";

            if ( user1 == "juan" && user2 == "pedro")
            {
                Console.WriteLine("Bienvenidos");
            }

            else { Console.WriteLine("No puede pasar"); }*/

            /* int n1 = 1;
             switch (n1)
             {
                 case 1:
                     Console.WriteLine("es el numero 1");
                     break;
                 case 3:
                     Console.WriteLine("es el numero 3");
                     break;*/

            /*for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("El valor es = " +  i);

            }*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); 
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i + " - " + j);
                    for (int k = 0; k < 10; k++)
                    {
                        Console.WriteLine(i + " - " + j + " - " + k);
                    }
                }
            }*/
            /*int i = 0;
            while (i < 10)
            {
                Console.WriteLine("El valor de i es = " + i);
                i++;

            }*/

            /*string[] nombres = {"juan", "pedro", "pepe", "maria" } ;
            foreach (string miNombre in nombres)
            {
                Console.WriteLine("Mi nombre es " + miNombre);
            }*/




        }
        }
    }
