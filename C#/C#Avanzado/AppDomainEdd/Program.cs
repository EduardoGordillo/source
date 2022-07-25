using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace AppDomainEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            // hacemos varias operaciones con los procesos de la maquina
            // hacemos uso de system.diagnostics

            // obtenemos la lista de procesos en la maquina

            var procesos = from proc in Process.GetProcesses() orderby proc.Id select proc;

            // recorremos los procesos encontrados

            //foreach (var proces in procesos)
            //{
            //    // para obtenes un proceso via su PID
            //    Console.WriteLine($"PID: {proces.Id}, Nombre: {proces.ProcessName}");
            //}

            Console.WriteLine("------------");


            //para obtener procesos via su id

            Process miProceso = null;
            int pid = 16392;
            try
            {
                miProceso = Process.GetProcessById(pid);
                Console.WriteLine($"PID : {pid}, Nombre : {miProceso} ");
                // obtenemos la lista de hilos del proceso
                ProcessThreadCollection hilos = miProceso.Threads;
                // recorremos los hilos encontrados
                foreach (ProcessThread hilo in hilos)
                {
                    Console.WriteLine($"Id del hilo {hilo.Id}, Inicio: {hilo.StartTime}" +
                        $"Prioridad: {hilo.PriorityLevel}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------");

            // un modulo es un .dll o .exe alojado en un proceso
            // un sistema de 32 bit no puede acceder a modulos de 64 bit, configurar correctamente
            Console.WriteLine($"Los modulos del proceso {miProceso.ProcessName} son:");

            // obtenemos los modulos
            ProcessModuleCollection modulos = miProceso.Modules;
            foreach (ProcessModule modulo in modulos)
                Console.WriteLine($"Modulo: {modulo}");

            Console.WriteLine("---------------");

            //Process otroProceso = null;
            //try
            //{
            //    // iniciamos el proceso de chrome.exe y le pasamos un parametro
            //    otroProceso = Process.Start("chrome.exe","www.youtube.com" );
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("opirme una tecla para continuar");
            //var cond = Console.ReadLine();

            //try
            //{
            //    if(cond == "hola")
            //    otroProceso.Kill();

            //}

            //catch(InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
    }
}
