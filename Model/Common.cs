using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompareServiceAPI.Model
{
    public class Common
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double TCCRating { get; set; }
        public int HwMPG { get; set; }
        public double BestValue { get; set; }
        public double FuelConsumption { get; set; }

    }

    public class AVGYear
    {
        public int Year { get; set; }
        public double Avg { get; set; }
    }
}