using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEcuaciones
{
    internal class EulerMejorado
    {
        private double funcion2(double x, double y)
        {
            return 2 * x * y;
        }

        private double yast(double x, double y, double h)
        {
            return y + (h * (funcion2(x, y)));
        }

        public void EulerMejorados(double x, double y, double h)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"x: {x}, y: {y}");
                double sid = funcion2(x, y);
                double sad = yast(x, y, h);
                x += h;
                y = y + h / 2 * (sid + funcion2(x, sad));
            }
        }
    }
}
