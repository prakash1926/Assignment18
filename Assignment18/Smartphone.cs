using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

     
        public Smartphone(string model)
        {
            Model = model;
            IsConnected = false;
            BatteryLevel = 0;
        }

        
        public bool Connect()
        {
            IsConnected = true;
            Console.WriteLine($"{Model} is connected.");
            return true;
        }

      
        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            Console.WriteLine($"{Model} is charged for {minutes} minutes.\n Battery level: {BatteryLevel}%");
        }

       
        public string Display()
        {
            return $"Display information for {Model}";
        }
    }
}
