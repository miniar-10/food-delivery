using Bon_appetit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models.Repositories
{
    public class RatingRepo : IRating
    {
        private readonly ApplicationDbContext _appContext;

        public RatingRepo(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<ProductRating> ProductsRatings => _appContext.Ratings;

        public IEnumerable<ProductRating> ProductRating(int ProductId)
        {
            return (_appContext.Ratings.Where(X => X.Food.FoodId == ProductId));
        }
    }
}
