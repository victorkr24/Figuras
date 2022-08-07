using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int opc;
            double lado;
            do
            {
                Console.WriteLine("Figuras Geometricas \n" +
                    "1-Cuadrado \n" +
                    "2-Triangulo \n"+
                    "3-Circulo");

                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        int cuadrado;
                        Console.WriteLine("Cuadrado");
                        Console.WriteLine("Elige una opcion \n+" +
                         "1-Area  \n" +
                         "2-Perimetro \n");

                        Console.WriteLine("Seleciona la opcion");
                        cuadrado = int.Parse(Console.ReadLine());

                        switch (cuadrado)
                        {
                            case 1:
                                
                                Cuadrado.CalcularArea();
                                break;

                            case 2:
                                Cuadrado.CalcularPerimetro();
                                break;
                           

                        }
                        break;

                    case 2:
                        int tri;
                        Console.WriteLine("Cuadrado");
                        Console.WriteLine("Elige una opcion \n+" +
                         "1-Area  \n" +
                         "2-Perimetro \n");

                        Console.WriteLine("Seleciona la opcion");
                        tri = int.Parse(Console.ReadLine());

                        switch (tri)
                        {
                            case 1:
                                Triangulo.CalcularArea();
                                break;
                            case 2:
                                Triangulo.CalcularPerimetro();
                                break;
                         
                        }
                        break;

                    case 3:
                        int circulo;
                        Console.WriteLine("Circulo");
                        Console.WriteLine("Elige una opcion \n+" +
                         "1-Area  \n" +
                         "2-Perimetro \n");

                        Console.WriteLine("Seleciona la opcion");
                        circulo = int.Parse(Console.ReadLine());

                        switch (circulo)
                        {
                            case 1:
                                Circulo.CalcularArea();
                                break;
                            case 2:
                                Circulo.CalcularPerimetro();
                                break;

                        }
                        break;


                }

            } while (opc != 6);
        }
    }
}
