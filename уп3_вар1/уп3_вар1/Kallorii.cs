using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace уп3_вар1
{
    public class Kallorii:Eat
    {
        public double Kkal { get; set; }

        public Kallorii(string name, double belok, double yglevods,double kkal):base(name,belok,yglevods)
        {
            Kkal = kkal;
        }
        public new double Q()
        {
            double Kascestvo=base.Q();
            double a = (Kascestvo * 1.2) + (Kkal * 7);
            return a;
        }
    }
}
