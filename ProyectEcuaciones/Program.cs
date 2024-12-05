using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEcuaciones
{
    internal class Program
    {
        static Ecuacion ecuacion = new Ecuacion();
        static Euler eulers = new Euler();
        static EulerMejorado eulerm = new EulerMejorado();
        static RungeKutta kutta = new RungeKutta();
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------------Euler------------------------------------------");
            ecuacion.x = 0;
            ecuacion.y = 3;
            ecuacion.h = 0.1;
            eulers.Eulers(ecuacion.x, ecuacion.y, ecuacion.h);

            Console.WriteLine("---------------------Euler Mejorado--------------------------------");

            ecuacion.x = 1;
            ecuacion.y = 1;
            eulerm.EulerMejorados(ecuacion.x, ecuacion.y, ecuacion.h);

            Console.WriteLine("---------------------Runge Kutta--------------------------------");
            ecuacion.x = 1;
            ecuacion.y = 1;
            kutta.RungeKuttas(ecuacion.x, ecuacion.y, ecuacion.h);

            Console.ReadKey();
        }


    }
}
