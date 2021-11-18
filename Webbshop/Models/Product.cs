using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageURL { get; set; }
        public bool ToCart{ get; set; }

        public int CartQuantity { get; set; }

    }
}
