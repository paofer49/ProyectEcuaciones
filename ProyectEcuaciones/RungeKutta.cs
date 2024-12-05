using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEcuaciones
{
    internal class RungeKutta
    {
        static Ecuacion ec = new Ecuacion();
        private double funcion(double x, double y) 
        { 
            return 2 * x * y;
        }

        public void RungeKuttas(double x, double y, double h) 
        {
            for (int i = 0; i < 10; i++)
            {
                ec.k1 = funcion(x, y);
                ec.k2 = funcion(x + h / 2, y + h / 2 * ec.k1);
                ec.k3 = funcion(x + h / 2, y + h / 2 * ec.k2);
                ec.k4 = funcion(x + h, y + h * ec.k3);
                Console.WriteLine($"X: {x}, Y: {y}, K1: {ec.k1}, K2: {ec.k2}, K3: {ec.k3}, K4: {ec.k4}");
                y = y + (h / 6) * (ec.k1 + ec.k2 * 2 + ec.k3 * 2 + ec.k4);
                x += h;
            }
        }
    }
}
