using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAppProjectFSD.Models
{
    public class CartPageVM
    {
        public string MovieName { get; internal set; }
        public string ImageURL { get; internal set; }
        public double Price { get; internal set; }
        public decimal CartSL { get; internal set; }
    }
}
