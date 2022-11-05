using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Biology : Average
    {
        private double biology1;
        private double biology2;
        private double biology3;
        private double all;
        public double Biology1
        {
            get { return biology1; }
            set { biology1 = value; }
        }
        public double Biology2
        {
            get { return biology2; }
            set { biology2 = value; }
        }
        public double Biology3
        {
            get { return biology3; }
            set { biology3 = value; }
        }
        public double All
        {
            get { return all; }
            set { all = value; }
        }

        public void average()
        {
             all = (biology1 + biology2 + biology3) / 3;
            Console.WriteLine("Biology average " + Math.Round(all, 0));
        }
    }
}
