using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moj_Prvi_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklaracija varijabli
            // int a, b;

            // definicija varijabli
            int a = 100;
            int b = 3;
            int x = a / b;
            int y = a % b;

            // ispisivanje
            string ispis = a + " dijeljeno s "
                + b + " je " + x + " i ostatak " 
                + y;
            Console.WriteLine(ispis);

            Console.ReadKey();
        }
    }
}
