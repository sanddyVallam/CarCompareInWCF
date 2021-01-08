using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarCompareServiceAPI.Model;

namespace CarCompareServiceAPI.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarCompare" in both code and config file together.
    [ServiceContract]
    public interface ICarCompare
    {
        [OperationContract]
        List<Common> NewestVehicleInOrder(int Year);

        [OperationContract]
        List<Common> AlphabeticalVehicle(bool isDescending);

        [OperationContract]
        List<Common> OrderListofVehicle(bool isDescending);

        [OperationContract]
        List<Common> BestValue();

        [OperationContract]
        List<Common> Fuelconsumption(double distance);

        [OperationContract]
        Common RandomCarPickup();

        [OperationContract]
        List<AVGYear> AvgMPG();


    }
}
