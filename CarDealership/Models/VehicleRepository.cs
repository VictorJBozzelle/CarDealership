using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class VehicleRepository
    {
        public static IEnumerable<Vehicle> GetAll()
        {
            var initialItems = new[]
            {
            new Vehicle { Make = "Nissan", Model = "Skyline R34", Year = 1999, Mileage = 155750 },
            new Vehicle { Make = "Chevrolet", Model = "El Camino", Year = 1981 },
            new Vehicle { Make = "Hyundai", Model = "Sonata 2.0t Limited", Year = 2013, Mileage = 210000 },
            new Vehicle { Make = "Mitsubishi", Model = "Eclipse GST", Year = 1995 }
            };
            return initialItems;
        }
    }
}
