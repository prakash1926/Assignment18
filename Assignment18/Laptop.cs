using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        
        public Laptop(string brand)
        {
            Brand = brand;
            IsConnected = false;
            BatteryLevel = 0;
        }

     
        public bool Connect()
        {
            IsConnected = true;
            Console.WriteLine($"{Brand} laptop is connected.");
            return true;
        }

        
        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            Console.WriteLine($"{Brand} laptop is charged for {minutes} minutes.\n Battery level: {BatteryLevel}%");
        }

     
        public string Display()
        {
            return $"Display information for {Brand} laptop";
        }
    }
}
