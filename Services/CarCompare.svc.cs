using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarCompareServiceAPI.DataManager;
using CarCompareServiceAPI.Model;

namespace CarCompareServiceAPI.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarCompare" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CarCompare.svc or CarCompare.svc.cs at the Solution Explorer and start debugging.
    public class CarCompare : ICarCompare
    {
        public List<Common> NewestVehicleInOrder(int Year)
        {
            return new CarCompareManager().NewestVehicleInOrder(Year);
        }
        public List<Common> AlphabeticalVehicle(bool isDescending)
        {
            return new CarCompareManager().AlphabeticalVehicle(isDescending);
        }
        public List<Common> OrderListofVehicle(bool isDescending)
        {
            return new CarCompareManager().OrderListofVehicle(isDescending);
        }
        public List<Common> BestValue()
        {
            return new CarCompareManager().BestValue();
        }
        public List<Common> Fuelconsumption(double distance)
        {
            return new CarCompareManager().Fuelconsumption(distance);
        }

        public Common RandomCarPickup()
        {
            return new CarCompareManager().RandomCarPickup();
        }

        public List<AVGYear> AvgMPG()
        {
            return new CarCompareManager().AvgMPG();
        }
    }
}
