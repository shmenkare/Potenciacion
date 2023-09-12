using System;
using System.Collections.Generic;
using System.Text;

namespace Potenciacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, num = 0, pot = 1, res = 1;

            Console.WriteLine("Ingrese el numero a potenciar");
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese la potencia a elevar");
            pot = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= pot; n++)
            {
                res *= num;
            
            
            }
            Console.WriteLine("{0} elvado a la {1} potencia es igual a {2}", num, pot, res);

            Console.ReadKey();
        }
    }
}
