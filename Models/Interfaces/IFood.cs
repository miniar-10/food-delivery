using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models.Interfaces
{
    public interface IFood
    {
        public IEnumerable<Food> Food { get; }
        public IEnumerable<Food> PreferredFood { get; }

        public IEnumerable<Food> Drinks { get; }

        public IEnumerable<Food> All { get; }

        Food GetFoodById(string id);
    }
}
