using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public String Name { get; set; }

        public String Description { get; set; }
        public String Image { get; set; }
        public float price { get; set; }

        
        public virtual Category Category { get; set; }



    }
}
