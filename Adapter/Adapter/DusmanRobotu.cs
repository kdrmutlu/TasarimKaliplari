using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class DusmanRobotu
    {
        public void YumrukAt()
        {
            Console.WriteLine("Yumruk atıldı.");
        }
        public void Yuru()
        {
            Console.WriteLine("Robot yürümeye başladı.");
        }
        public void RobotIsim(string isim)
        {
            Console.WriteLine("Robot İsmi:" + isim);
        }
    }
}
