using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class GSM
    {
        private string manufacturer;//task 1.
        private double price;//task 1.
        private string owner;//task 1.
        private string model;//task 1.
        private Battery battery;//task 1.
        private Display display;//task 1.
        private static GSM Iphone4S;//task 6
   //task 2. Constructors
        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display)
        {
            this.model = "Ipone4S";
        }
        public GSM(string model, string manufacturer, string owner)
        {
            this.owner = owner;
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public static string PrintInfo(string manufacturer, double price, string model, Battery battery, Display display)//task 4. 
        {
           string info= $"Manufacturer:{manufacturer}\nPrice:{price}\nModel:{model}\nBattery:{battery}\nDisplay{display}";
            return info;
        }
        public override string ToString()//task 4.
        {
            return "GSM: " + model + " " + manufacturer + " " + price + " " + battery + " " + display + " " + owner;
        }
        //task 10.
        public void AddCall(DateTime date, string number, int duration)
        {
            this.CallHistory.Add(new Calls(date, number, duration));

        }

        public List<Calls> DeleteCalls(Calls call)
        {
            this.CallHistory.Remove(call);
            return new List<Calls>(this.CallHistory);
        }

        public List<Calls> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return new List<Calls>(this.CallHistory);
        }
        //task 11.
        public double CallCost(List<Calls> CallHistory, double pricePerMinute)
        {
            int durationHistory=0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                durationHistory+=CallHistory[i].Duration;
            }
            double callPrice = (durationHistory / 60) * pricePerMinute; //because the duration is in seconds
            return callPrice;

        }
        //task 12.
        public void DeleteLongestCall()
        {
            int maxDurationIndex = 0;
            int maxDuration = 0;
            if (this.CallHistory.Count > 0)
            {
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    if (this.CallHistory[i].Duration > maxDuration)
                    {
                        maxDuration = this.CallHistory[i].Duration;
                        maxDurationIndex = i;
                    }

                }
                this.CallHistory.RemoveAt(maxDurationIndex);
            }
        }
        public string CallHistoryPrint()
        {
            StringBuilder CallHitoryPrintStr = new StringBuilder();
            if (this.CallHistory.Count==0)
            {
                return "Call history is empty.";
            }
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                CallHitoryPrintStr.Append(this.CallHistory[i].ToString());
            }
            return CallHitoryPrintStr.ToString();
        }
        //Properties
        //task 5.
        public string GsmManufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length == 0 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Name should be longer than 0 and shorter than 15 characters");
                }
                else
                {
                    this.manufacturer = value;
                }

            }
        }
             public string GsmModel
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length == 0 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Name should be longer than 0 and shorter than 10 characters");
                }
                else
                {
                    this.model = value;
                }

            }
        }
        public string GsmOwner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Name should be longer than 2 and shorter than 30 characters");
                }
                else
                {
                    this.owner = value;
                }

            }
        }
        public double GsmPrice
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price can't be negative");
                }
                else
                {
                    this.price = value;
                }

            }
        }
        public Battery GsmBattery
        {
            get { return this.battery; }
            private set { this.battery = value; }

        }

        public Display GsmDisplay
        {
        get { return this.display; }
        private set { this.display = value; }

        }
        public static GSM IPhone4S //task6
        {
            get { return IPhone4S; }
            set { IPhone4S = value; }
        }
       public List<Calls> CallHistory //task 9.
        {
           get { return this.CallHistory; }
           set { this.CallHistory = value; }
        }


    }





}
