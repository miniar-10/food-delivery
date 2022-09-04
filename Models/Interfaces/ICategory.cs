using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models.Interfaces
{
    public interface ICategory
    {
       public IEnumerable<Category> Categories { get; }
        Category GetCategoryById(string id);
        //Food GetAllById(string id);
    }
}
