using System;
using System.Linq;
using CarDealership.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(VehicleRepository.Vehicles);
        }

        [HttpGet]
        public IActionResult CarEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CarEntry(Vehicle vehicle)
        {
            VehicleRepository.AddVehicle(vehicle);
            return RedirectToAction("Index");
        }
    }
}