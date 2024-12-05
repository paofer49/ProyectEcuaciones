using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEcuaciones
{
    internal class Euler
    {
        public double funcion(double x, double y)
        {
            return x / y;
        }

        public void Eulers(double x, double y, double h)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"x: {x}, y: {y}");
                x += h;
                y = y + h * (funcion(x, y));
            }
        }
    }
}
