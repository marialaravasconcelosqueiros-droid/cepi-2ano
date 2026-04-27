using primeiroProjeto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sla
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture ) ;
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture ) ;
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture ) ;

            double areaX = x.Area();//Fução matematica raiz > math.sqrt

            double areaY = y.Area();//Função matematica raiz > math.sqrt

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
