using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson.H1.CsharpFeatures.Domain;
using Lesson.H1.CsharpFeatures.WebApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson.H1.CsharpFeatures.WebApp.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "List of furniture";

            List<Furniture> furnitures = Furniture.GetAll();

            return View(furnitures);
        }

        public IActionResult Detail()
        {
            ViewData["Title"] = "Detail of furniture";

            List<Furniture> furnitures = Furniture.GetAll();

            FurnitureListViewModel furnitureViewModel = new FurnitureListViewModel
            {
                Furnitures = furnitures,
                Count = furnitures.Count,
                QuoteOfTheDay = "The best furniture in Town"
            };

            return View(furnitureViewModel);
        }


    }
}
