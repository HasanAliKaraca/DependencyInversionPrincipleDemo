using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Abstraction;
using DIP.HighLevelModule;
using DIP.LowLevelModule;

namespace DIP.After.Client
{
    class Program
    {
        /*
         * New Problem: Now program is dependent on the low level module classes. 
         * Solution: Dependency injection
         */
        static void Main(string[] args)
        {
            string msg;

            //IVehicle vehicle = new Plane();
            IVehicle vehicle = new Tank();

            Commander commander = new Commander(vehicle);
            msg = commander.Move();
            Console.WriteLine(msg);
            msg = commander.Fire();
            Console.WriteLine(msg);
            
            Console.Read();
        }
    }
}
