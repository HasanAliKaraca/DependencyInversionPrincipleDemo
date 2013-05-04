using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Before.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            Commander commander = new Commander();
            commander.VehicleType = EnmVehicleType.Plane;
            msg = commander.Move();

            Console.WriteLine(msg);

            commander.VehicleType = EnmVehicleType.Tank;
            msg = commander.Fire();

            Console.WriteLine(msg);
            Console.Read();
        }
    }

    //base class for vehicles
    abstract class Vehicle
    {
        public abstract string Fire();

        public abstract string Move();
    }

    class Tank : Vehicle
    {
        public override string Fire()
        {
            return "tank fires";
        }

        public override string Move()
        {
            return "tank moves";
        }
    }

    class Plane : Vehicle
    {
        public override string Fire()
        {
            return "plane fires";
        }

        public override string Move()
        {
            return "plane moves";
        }
    }

    enum EnmVehicleType
    {
        Plane,
        Tank
    }

    class Commander
    {
        public Tank Tank { get; set; }
        public Plane Plane { get; set; }
        public EnmVehicleType VehicleType { get; set; }

        public Commander()
        {
            Tank = new Tank();
            Plane = new Plane();
        }

        public string Fire()
        {
            switch (VehicleType)
            {
                case EnmVehicleType.Plane:
                    return Plane.Fire();
                case EnmVehicleType.Tank:
                    return Tank.Fire();
                default:
                    return "";
            }
        }

        public string Move()
        {
            switch (VehicleType)
            {
                case EnmVehicleType.Plane:
                    return Plane.Move();
                case EnmVehicleType.Tank:
                    return Tank.Move();
                default:
                    return "";
            }
        }
    }
}
