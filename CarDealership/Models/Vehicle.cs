using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Vehicle
    {
        [Required(ErrorMessage = "Please enter the Year of the vehicle")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the Make of the vehicle")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter the Model of the vehicle")]
        public string Model { get; set; }

        public int? Mileage { get; set; }
    }
}
