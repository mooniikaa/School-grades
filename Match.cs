using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
     class Match : Average
    {
        private double match1;
        private double match2;
        private double match3;
        private double all;
        public double Match1
        {
            get { return match1; }
            set { match1 = value; }
        }
        public double Match2
        {
            get { return match2; }
            set { match2 = value; }
        }
        public double Match3
        {
            get { return match3; }
            set { match3 = value; }
        }
        public double All
        {
            get { return all; }
            set { all = value; }
        }
        public void average()
        {
            all = (match1 + match2 + match3) / 3;
            Console.WriteLine("Match average " + Math.Round(all, 0));
        }
    }
}
