using Bon_appetit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models.Repositories
{
    public class FoodRepo : IFood
    {
        private readonly ApplicationDbContext _appContext;

        public FoodRepo(ApplicationDbContext applicationDbContext){
            _appContext = applicationDbContext;
            }
        public IEnumerable<Food> Food =>_appContext.Products.Where(X => X.Category.CategoryId < 4);

        public IEnumerable<Food> PreferredFood => _appContext.Products;
            //.OrderByDescending(u => (u.Rate).Sum() / u.Count).Take(7);;

        //var items = context.PersonSet.OrderByDescending(u => u.OnlineAccounts.Count).Take(5);

        public IEnumerable<Food> Drinks => _appContext.Products.Where(C=>C.Category.CategoryId>3);
          

        public IEnumerable<Food> All => _appContext.Products;

        public Food GetFoodById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
