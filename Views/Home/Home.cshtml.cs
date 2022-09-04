using Bon_appetit.Models;
using Bon_appetit.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Bon_appetit.Views
{
    public class HomeModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;
        public AllFoodService productsService;
        public IEnumerable<Food> Food { get;private set;}

        public HomeModel(
            ILogger<HomeModel> logger,
            AllFoodService productsServices)
        {
            _logger = logger;
            this.productsService = productsServices;
        }

        public void OnGet()
        {
            Food = productsService.GetAll();
        }
    }
}
