using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEcuaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Euler------------------------------------------");
            double x = 0;
            double y = 3;
            double h = 0.1;
            Euler(x, y, h);

            Console.WriteLine("---------------------Euler Mejorado--------------------------------");

            double x2 = 1;
            double y2 = 1;
            EulerMejorado(x2, y2, h);

            Console.ReadKey();
        }

        static double funcion(double x, double y) 
        {
            return x/y;
        }

        static void Euler(double x, double y, double h) 
        {
            for (int i = 0; i <15; i++)
            {
                Console.WriteLine($"x: {x}, y: {y}");
                x += h;
                y = y + h * (funcion(x, y));
            }
        }

        static double funcion2(double x, double y) 
        { 
            return 2 * x * y;
        }

        static double yast(double x, double y, double h) 
        { 
            return y + (h * (funcion2(x, y)));
        }

        static void EulerMejorado(double x, double y, double h) 
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"x: {x}, y: {y}");
                double sid = funcion2(x, y);
                double sad =yast(x,y, h);
                x += h;
                y = y + h/2 * (sid + funcion2(x,sad));
            }
        }
    }
}
