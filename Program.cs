using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2;

            Console.Write("digite valor 1: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("digite valor o 2: ");
            v2 = double.Parse(Console.ReadLine());

            if (v1 == v2)
                Console.WriteLine("valor 1 e valor 2 são iguais");
            else
                if (v1 > v2)
                Console.WriteLine("valor 1 e maior ");
            else
                Console.WriteLine("valor 2 e maior ");
            
            
        }
    }
}
