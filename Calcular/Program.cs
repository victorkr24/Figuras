using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine("Par"); 
            }
            for(int i= 1; i <= 20; i+= 2)
           {
               Console.WriteLine("Impar");
            }
            Console.ReadKey();  
        }
    }
}
