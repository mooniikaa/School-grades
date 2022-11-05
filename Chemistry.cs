using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Chemistry : Average
    {
        private double chem1;
        private double chem2;
        private double chem3;
        private double all;
        public double Chem1
        {
            get { return chem1; }
            set { chem1 = value; }
        }
        public double Chem2
        {
            get { return chem2; }
            set { chem2 = value; }
        }
        public double Chem3
        {
            get { return chem3; }
            set { chem3 = value; }
        }
        public double All
        {
            get { return all; }
            set { all = value; }
        }
        public void average()
        {
            all = (chem1 + chem2 + chem3) / 3;
            Console.WriteLine("Chemistry average " + Math.Round(all, 0));
        }
    }
}
