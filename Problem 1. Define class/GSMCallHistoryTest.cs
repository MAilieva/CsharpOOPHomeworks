using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class GSMCallHistoryTest //task 12.
    {
        //Create an instance of the GSM class.
        private static GSM currentGsm = new GSM("IPhone", "Apple", "Pesho");
        private static double currentPrice = 0.37;
       
        static void Main()
        {
            currentGsm.AddCall(new DateTime(20016, 06, 15, 13, 45, 30), "0889 888 769", 400);
            currentGsm.AddCall(new DateTime(200216, 12, 20, 13, 49, 30), "0889 898 769", 300);
            currentGsm.AddCall(new DateTime(20016, 06, 15, 13, 45, 30), "0889 888 769", 1200);
            currentGsm.AddCall(DateTime.Now, "0889 898 800", 30);

            Console.WriteLine($"Call history:{currentGsm.CallHistory}");
            double callcost=currentGsm.CallCost(currentGsm.CallHistory, currentPrice);
            Console.WriteLine($"Price for calls:{callcost}");
            

            currentGsm.DeleteLongestCall();
            double newCallcost = currentGsm.CallCost(currentGsm.CallHistory, currentPrice);
            Console.WriteLine($"Price for calls:{newCallcost}");

            currentGsm.ClearCallHistory();
            Console.WriteLine(currentGsm.CallHistoryPrint());
            
        }
       
    }
}



