using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class Battery//task 1.
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;//task 3
        public Battery() //task 2.
        {
            this.model = "LiIon";
            this.hoursIdle = 300;

        }
        public Battery(string model, int hoursIdle, int hoursTalk)//task 2.
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;

        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)//public 2.
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = BatteryType;

        }
        //task 5.
        public string BatteryModel
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length <= 0 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Modelname should be longer than 0 and shorter than 10 symbols");
                }
                else
                {
                    this.model = value;
                }
            }

        }
        public int BatteryHoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value <= 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Hours should be not less than 0 and not more than 300 hours");
                }
                else
                {
                    this.hoursIdle = value;
                }


            }
        }
        public int BatteryHoursTalk
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value <= 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Hours should be not less than 0 and not more than 300");
                }
                else
                {
                    this.hoursTalk = value;
                }


            }
        }
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            private set { this.batteryType = value; }
        }
    }
}
