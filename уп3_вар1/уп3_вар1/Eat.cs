using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace уп3_вар1
{
    public class Eat
    {
        public string Name { get; set; }
        public double Belok { get; set; }
        public double Yglevods { get; set; }

        public Eat(string name, double belok, double yglevods)        {
            Name = name;
            Belok = belok;
            Yglevods = yglevods;
        }

        public double Q()
        {
            return (Yglevods*4) + (Belok*4);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
