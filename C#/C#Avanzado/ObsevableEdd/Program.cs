using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsevableEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            /// coleccion observable

            ObservableCollection<CPunto> puntos = new ObservableCollection<CPunto>
            {
                new CPunto(1,33),
                new CPunto(8,6)
            };

            puntos.CollectionChanged += delegate (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
            {
                {
                
                    // ver el tipo de evento que sucedio
                    Console.WriteLine("El evento es {0}", e.Action);

                    // si es adicionar
                    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                    {
                        Console.WriteLine("Elementos Nuevos");
                        foreach (CPunto p in e.NewItems)
                        {
                            Console.WriteLine(p.ToString());
                        }

                    }
                    // si es remover
                    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                    {
                        Console.WriteLine("Elementos afectados por el cambio");
                        foreach (CPunto p in e.OldItems)
                            Console.WriteLine(p.ToString());

                    }
                    Console.WriteLine("-----------");
                }
            };


            puntos.Add(new CPunto(5,5));
            CPunto miPunto = new CPunto(6,3);

            puntos.Add(miPunto);

            puntos.Remove(puntos[0]);
            puntos.RemoveAt(1);
            
        }


        // este el handler  que se invoca cuando cambia ka coleccion
        //static void punto_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //  // ver el tipo de evento que sucedio
        //    Console.WriteLine("El evento es {0}", e.Action);

        //    // si es adicionar
        //    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        //    {
        //        Console.WriteLine("Elementos Nuevos");
        //        foreach (CPunto p in e.NewItems)
        //        {
        //            Console.WriteLine(p.ToString());
        //        }

        //    }
        //    // si es remover
        //    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
        //    {
        //        Console.WriteLine("Elementos afectados por el cambio");
        //        foreach (CPunto p in e.OldItems)
        //            Console.WriteLine(p.ToString());

        //    }
        //    Console.WriteLine("-----------");
        //}
    }
}
