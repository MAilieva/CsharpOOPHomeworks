using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class Display//task 1.
    {
        private int size;
        private int numberOfColors;

        public Display()
        {
            this.size = 1;
            this.numberOfColors = 300;
        }
        public Display(int size, int numberOfcolors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
        //task 5.
        public int DisplaySize
        {
            get { return this.size; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the display can't be negative number or 0");
                }

                { this.size = value; }
            }
        }
        public int DisplayNumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 2)
                {
                    throw new ArgumentException("The display must have more than 2 colors");
                }

                { this.numberOfColors = value; }
            }
        }
    }

}
