using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Abstraction;

namespace DIP.LowLevelModule
{
    public class Plane : IVehicle
    {
        #region IVehicle Members

        public string Fire()
        {
            return "plane fires";
        }

        public string Move()
        {
            return "plane moves";
        }

        #endregion
    }
}
