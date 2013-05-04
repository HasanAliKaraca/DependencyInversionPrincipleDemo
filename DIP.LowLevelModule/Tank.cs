using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Abstraction;

namespace DIP.LowLevelModule
{
    public class Tank : IVehicle
    {
        #region IVehicle Members

        public string Fire()
        {
            return "tank fires";
        }

        public string Move()
        {
            return "tank moves";
        }

        #endregion
    }
}
