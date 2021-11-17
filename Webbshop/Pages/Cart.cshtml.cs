using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webbshop.Models;
using Webbshop.Data;

namespace Webbshop.Pages
{
    public class CartModel : PageModel
    {

        public List<Product> CartList = CartManager.CartList;

        [BindProperty]
        public double TotalPrice { get; set; }
        public void OnGet(string removeId)
        {
            TotalPrice = CartManager.TotalPrice;

            if (removeId != null )
            {
                CartManager.RemoveFromCart(removeId);
            }

        }

        public void OnPost()
        {


            //CartList = CartList.OrderBy(product => product.Price).ToList();
        }

    }
}
