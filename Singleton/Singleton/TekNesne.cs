using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class TekNesne
    {
        private static TekNesne ornek;

        private TekNesne(){}
        public static TekNesne ornekGetir()
        {
            if (ornek == null)
            {
                ornek = new TekNesne();
                Console.WriteLine("Yeni Örnek nesne üretildi.");
            }
            else
                Console.WriteLine("Önceden yaratılmış örnek geri döndürüldü.");

            return ornek;
        }

    }
}
