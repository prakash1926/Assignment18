using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone myPhone = new Smartphone("iPhone");
            Laptop myLaptop = new Laptop("Dell");

            myPhone.Connect();
            myLaptop.Connect();

            myPhone.Charge(30);
            myLaptop.Charge(45);

            Console.WriteLine(myPhone.Display());
            Console.WriteLine(myLaptop.Display());

            Console.ReadLine();
        }
    }
}
