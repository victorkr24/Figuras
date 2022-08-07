using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Triangulo
    {

        public static void CalcularArea()
        {
            Console.WriteLine("Ingrese la altura del traingulo ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la base del traingulo ");
            double basse = double.Parse(Console.ReadLine());

            double area = (basse * altura)/2;

            Console.WriteLine("El area del traingulo es " + area);
        }

        public static void CalcularPerimetro()
        {
            Console.WriteLine("Ingrese la altura del traingulo ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la base del traingulo ");
            double basse = double.Parse(Console.ReadLine());


            double perimetro = basse + altura + basse;
            Console.WriteLine("El perimetro del trangulo es "+perimetro);
        }
    }
}
