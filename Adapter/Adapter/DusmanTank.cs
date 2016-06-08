using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class DusmanTank : IDusman

    {
        public void SilahKullan()
        {
            Console.WriteLine("Silah kullanildi.");
        }

        public void Hizlan()
        {
            Console.WriteLine("Hızlanıldı.");
        }

        public void DusmanAdi(string ad)
        {
            Console.WriteLine("Düşmanın Adı: " + ad);
        }
    }
}
