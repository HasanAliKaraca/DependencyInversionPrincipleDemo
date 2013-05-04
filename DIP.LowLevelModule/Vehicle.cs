using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Abstraction;

namespace DIP.LowLevelModule
{
    abstract public class Vehicle : IVehicle
    {
        #region IVehicle Members

        public abstract string Fire();

        public abstract string Move();

        #endregion
    }
}
