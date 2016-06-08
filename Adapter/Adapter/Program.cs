using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            DusmanTank t1 = new DusmanTank();
            t1.SilahKullan();
            t1.Hizlan();
            t1.DusmanAdi("Düşman1");

            DusmanRobotu robot1 = new DusmanRobotu();
            robot1.YumrukAt();
            robot1.Yuru();
            robot1.RobotIsim("Asimo");

            /* Adaptasyonu burada kullanıyoruz. */
            IDusman dusman = new DusmanRobotuAdapter(robot1);
            dusman.SilahKullan();
            dusman.Hizlan();
            dusman.DusmanAdi("Kadir");

            Console.ReadLine();
        }
    }
}
