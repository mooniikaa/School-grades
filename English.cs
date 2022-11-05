using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class English : Average
    {
        private double english1;
        private double english2;
        private double endlish3;
        private double all;
        public double English1
        {
            get { return english1; }
            set { english1 = value; }
        }
        public double English2
        {
            get { return english2; }
            set { english2 = value; }
        }
        public double English3
        {
            get { return endlish3; }
            set { endlish3 = value; }
        }
        public double All
        {
            get { return all; }
            set { all = value; }
        }
        public void average()
        {
            all = (english1 + english2 + endlish3) / 3;
            Console.WriteLine("English average " + Math.Round(all, 0));
        }
    }
}
