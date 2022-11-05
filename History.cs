using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class History : Average
    {
        private double history1;
        private double history2;
        private double history3;
        private double all;
        public double History1
        {
            get { return history1; }
            set { history1 = value; }
        }
        public double History2
        {
            get { return history2; }
            set { history2 = value; }
        }
        public double History3
        {
            get { return history3; }
            set { history3 = value; }
        }
        public double All
        {
            get { return all; }
            set { all = value; }
        }
        public void average()
        {
            all = (history1 + history2 + history3) / 3;
            Console.WriteLine("History average " + Math.Round(all, 0));
        }
    }
}
