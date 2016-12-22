using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class GSMTest//task 7.
    {
        //Create an array of few instances of the GSM class.
        static string[] manufacturer = new string[] { "Samsung", "Apple", "Huawei", "Sony", "GooglePixel" };
        static string[] model = new string[] { "Galaxy", "4S", "347S", "Z3", "Mini" };
        static double[] price = new double[] { 1000, 900, 300, 400, 2000 };
        static string[] owner = new string[] { "Michel", "Petur", "Sven", "George", "Philip" };
        static Battery battery = new Battery("SPM", 300, 400, BatteryType.LiIon);
        static Display display = new Display(300, 400);
        //Create an array of few instances of the GSM class. && //Display the information about the static property IPhone4S.
        public static GSM[] GsmInstances()
        {
            GSM[] arr = new GSM[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = new GSM(model[i], manufacturer[i], owner[i], price[i], battery, display);
			}
            return arr;
        }
        public static void Print(GSM[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Generated GSM {0}: {1}", i + 1, string.Join(" ", arr[i]));
            }

            Console.WriteLine($"IPhone {GSM.IPhone4S}");
        }
      
        

    }
}
