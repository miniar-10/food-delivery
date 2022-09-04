using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models.Interfaces
{
    public interface IRating
    {
        public IEnumerable<ProductRating> ProductsRatings { get; }
        public IEnumerable<ProductRating> ProductRating(int ProductId);

    }
}
