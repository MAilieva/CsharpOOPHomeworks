using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class Calls //task 8.
    {
        private DateTime date;
        private DateTime time;
        private string number;
        private int duration;

        public Calls(DateTime date, string number, int duration)
        {
            this.date = date;
            this.number = number;
            this.duration = duration;
        }
        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public string Number
        {
            get { return this.number; }
            private set
            {
                if (value.Length < 10||value.Length>13)
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentException("The phone number must not be more than 13 digits and less than 10 digits.");
                }
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("There should not be negative duration");
                }
                else
                {
                    this.duration = value;
                }
            }
        }

    }
}
