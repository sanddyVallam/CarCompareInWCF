using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompareServiceAPI.Model;

namespace CarCompareServiceAPI.DataManager
{
    public class CarCompareManager
    {

        private static double AvgFuelCost = 2.0;
        private static int MinMilagePerYear = 12000;
        private List<Common> GetData()
        {
            List<Common> CarDetails = new List<Common>();
            CarDetails.Add(new Common { Make = "Honda", Color = "Green", Model = "CRV ", HwMPG = 33, Price = 23845, TCCRating = 8, Year = 2016 });
            CarDetails.Add(new Common { Make = "Ford ", Color = "Red", Model = "Escape ", HwMPG = 32, Price = 23590, TCCRating = 7.8, Year = 2017 });
            CarDetails.Add(new Common { Make = "Hyundai ", Color = "Grey", Model = "Sante Fe", HwMPG = 27, Price = 24950, TCCRating = 8, Year = 2016 });
            CarDetails.Add(new Common { Make = "Mazda ", Color = "Red", Model = "CX-5", HwMPG = 35, Price = 21795, TCCRating = 8, Year = 2017 });
            CarDetails.Add(new Common { Make = "Subaru ", Color = "Blue", Model = "Forester", HwMPG = 32, Price = 22395, TCCRating = 8.4, Year = 2016 });

            return CarDetails;
        }

        public List<Common> NewestVehicleInOrder(int Year)
        {
            //Get Data of CarCompare
            var NewVehicle = GetData();
            //Assign variable Year with Max Year of table if it is null
            if (Year == 0)
                Year = NewVehicle.Max(s => s.Year);

            return NewVehicle.Where(s => s.Year == Year).ToList();
        }

        public List<Common> AlphabeticalVehicle(bool isDescending)
        {
            if (isDescending)
                return GetData().OrderByDescending(s => s.Make).ToList();
            else
                return GetData().OrderBy(s => s.Make).ToList();
        }

        public List<Common> OrderListofVehicle(bool isDescending)
        {
            if (isDescending)
                return GetData().OrderByDescending(s => s.Price).ToList();
            else
                return GetData().OrderBy(s => s.Price).ToList();
        }

        public List<Common> BestValue()
        {
            //var MinMilesPerYear = 12000;
            //var AvgFuel = 2.0;
            var Vehicles = GetData();
            foreach (var EachCar in Vehicles)
            {
                EachCar.BestValue = Convert.ToDouble(EachCar.Price) + ((MinMilagePerYear / EachCar.HwMPG) * AvgFuelCost);

            }
            var MinValue = Vehicles.Min(s => s.BestValue);
            return Vehicles.Where(s => s.BestValue == MinValue).ToList();
        }

        public List<Common> Fuelconsumption(double distance)
        {
            var Vehicles = GetData();
            foreach (var EachVeh in Vehicles)
            {
                EachVeh.FuelConsumption = (distance / EachVeh.HwMPG);
            }
            return Vehicles;
        }

        public Common RandomCarPickup()
        {
            var random = new Random();
            var Vehicles = GetData();
            int index = random.Next(Vehicles.Count);
            return Vehicles[index];
        }
        public List<AVGYear> AvgMPG()
        {
            var AvgerageMPG = GetData()
                            .GroupBy(s => s.Year)
                            .Select(g => new AVGYear { Year = g.Key, Avg = g.Average(s => s.HwMPG) }).ToList();

            return AvgerageMPG;
        }
    }
}