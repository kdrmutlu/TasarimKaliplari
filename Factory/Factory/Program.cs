using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            SekilFactory sekilFactory = new SekilFactory();

            ISekil sekil1 = sekilFactory.getSekil(ESekilTur.cember);
            sekil1.Ciz();

            ISekil sekil2 = sekilFactory.getSekil(ESekilTur.dikdortgen);
            sekil2.Ciz();

            ISekil sekil3 = sekilFactory.getSekil(ESekilTur.kare);
            sekil3.Ciz();

            Console.ReadLine();
        }
    }
}
