using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TekNesne n1 = TekNesne.ornekGetir();
            TekNesne n2 = TekNesne.ornekGetir();
            TekNesne n3 = TekNesne.ornekGetir();

            Console.ReadLine();
        }
    }
}
