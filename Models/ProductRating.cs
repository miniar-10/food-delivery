using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models
{
    public class ProductRating
    {
        private int rateId;
        private int productId;

        //public ProductRating(int ProductRatingId, int  FoodId, int rate)
        //{
        //    this.rateId = ProductRatingId;
        //    this.productId = FoodId;
        //    this.Rate = rate;
        //}

        public int ProductRatingId { get; set; }
        public virtual Food Food { get; set; }

        public int Rate { get; set; }
    
    }
}
