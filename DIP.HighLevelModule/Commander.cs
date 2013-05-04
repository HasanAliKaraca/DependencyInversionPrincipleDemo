using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Abstraction;

namespace DIP.HighLevelModule
{
    public class Commander
    {
        #region after dip
        private IVehicle _vehicle;

        public Commander(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string Fire()
        {
            return _vehicle.Fire();
        }
        public string Move()
        {
            return _vehicle.Move();
        }
        #endregion

        #region before dip
        /*
        public Tank Tank { get; set; }
        public Plane Plane { get; set; }
        public EnmVehicleType VehicleType { get; set; }

        public void MoveVehicle()
        {
            switch (VehicleType)
            {
                case EnmVehicleType.Plane:
                    break;
                case EnmVehicleType.Tank:
                    break;
                default:
                    break;
            }
        }
        */
        #endregion

        #region notes
        /*
         * Now this class doesnt know any of the low classes. It just knows the interface
         * 
         */
        #endregion
    }
}
