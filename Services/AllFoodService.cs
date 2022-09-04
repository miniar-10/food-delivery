using Bon_appetit.Models;
using Bon_appetit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Services
{
    public class AllFoodService { 
        private readonly ApplicationDbContext _context;
    
        private readonly IFood _food;
        private readonly IRating _ratings;
        private static int  RateId=1;
        public AllFoodService(IFood IFood ,IRating IRating ,ApplicationDbContext context)
        {
            _food = IFood;
            _ratings = IRating;
            _context = context;
        }
        public IEnumerable <Food> GetAll()
        {
            return _food.All;
        }

        public IEnumerable<Food> GetFood()
        {
            return _food.Food;
        }

        public IEnumerable<Food> GetDrinks()
        {
            return _food.Drinks;
        }

        public IEnumerable<Food> GetPreferred()
        {
            return _food.All;
        }
        public IEnumerable<ProductRating> GetRating(int ProductId)
        {
            return _ratings.ProductRating(ProductId);
        }
        public void AddRating(Food product,int Rate)
        {
            var rating = new ProductRating();
           //rating.ProductRatingId = RateId;
            rating.Rate = Rate;
            rating.Food = product;
            _context.Add(rating);
            _context.SaveChanges();
            
        }

    }
}
