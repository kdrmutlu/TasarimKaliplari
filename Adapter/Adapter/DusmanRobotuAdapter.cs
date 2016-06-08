using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class DusmanRobotuAdapter : IDusman
    {
        private DusmanRobotu robot;
        public DusmanRobotuAdapter(DusmanRobotu yenirobot)
        {
            robot = yenirobot;
        }

        public void SilahKullan()
        {
            robot.YumrukAt();
        }

        public void Hizlan()
        {
            robot.Yuru();
        }

        public void DusmanAdi(string ad)
        {
            robot.RobotIsim(ad);
        }
    }
}
