using Bon_appetit.Models;
using Bon_appetit.Models.Interfaces;
using Bon_appetit.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFood _food;
        public AllFoodService FoodServices { get; }

        public HomeController(IFood IFood,AllFoodService foodService)
        {
            _food = IFood;
            this.FoodServices = foodService;
        }

        public ActionResult Home()
        {

            ViewBag.foodList = _food.All;
            return View(FoodServices.GetAll());
        }
        public ActionResult Food()
        {

            ViewBag.foodList = _food.Food;
            return View();
        }
        public ActionResult Drinks()
        {

            ViewBag.foodList = _food.Drinks;
            return View(_food.Drinks);
        }
        public ActionResult Preferred()
        {

            ViewBag.foodList = _food.All;
            return View();
        }
        [HttpGet]
        public IEnumerable<Food> Get()
        {
            return FoodServices.GetAll();
        }

        public ActionResult Details(int id)
        {

            var meal = _food.All.Where(x => x.FoodId == id).FirstOrDefault();
            return PartialView(meal);
        }

        public IActionResult Loginn()
        {

            return View();
        }
        public IActionResult    SignUp()
        {

            return View();
        }

        //    private readonly ILogger<HomeController> _logger;

        //    public HomeController(ILogger<HomeController=> logger)
        //    {
        //        _logger = logger;
        //    }

        //    public IActionResult Index()
        //    {
        //        return View();
        //    }

        //    public IActionResult Privacy()
        //    {
        //        return View();
        //    }

        //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //    public IActionResult Error()
        //    {
        //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //    }
        //}
    }
}