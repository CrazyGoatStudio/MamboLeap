using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotion_visualizer.Modificadores
{
    public class AngleSerializer
    {
        public float SerializeAngle(float a) {
            if (a <= 90 && a >= -90)
            {
                return a;
            }
            else if (a > 90)
            {
                a = 90;
            }
            else
            {
                a = -90;
            }
            return a;
        }
    }
}
