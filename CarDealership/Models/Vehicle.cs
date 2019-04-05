using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Mileage { get; set; }
    }
}
