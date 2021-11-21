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
        [BindProperty]
        public string PostalCode { get; set; } 

        [BindProperty]
        public string Adress { get; set; }

        [BindProperty]
        public string WholeName { get; set; }

        [BindProperty]
        public string PhoneNumber { get; set; }

        [BindProperty]
        public string CardNumber { get; set; }

        [BindProperty]
        public string CVCcode { get; set; }

        [BindProperty]
        public string CardHolder { get; set; }

        [BindProperty]
        public string CardExpire { get; set; }

        [BindProperty]
        public double ShowMoms { get; set; }

        [BindProperty]
        public bool ExpressShipping { get; set; }

        [BindProperty]
        public double PriceIncShipping { get; set; }
        public void OnGet(string removeId, bool expressShipping, string incQuantity, string decQuantity)
        {

            if (removeId != null ) //Remove product from cart
            {
                CartManager.RemoveFromCart(removeId);
            }



            if (expressShipping)
            {
                PriceIncShipping = TotalPrice + 199; //Price with express shipping.
            }

            if (incQuantity != null) //Increase quantity for product in cart
            {
                CartManager.IncQuantity(incQuantity);
                incQuantity = null;
            }

            if (decQuantity != null) //Decrease quantity for product in cart
            {
                CartManager.DecQuantity(decQuantity);
                decQuantity = null;
            }

            //TotalPrice = CartManager.TotalPrice;
            TotalPrice = CartManager.GetPriceSum();

            ShowMoms = TotalPrice / 4;

            PriceIncShipping = TotalPrice; //Price with free shipping.

        }

        public void OnPost(bool expressShipping)
        {
            ExpressShipping = expressShipping;
            PriceIncShipping = TotalPrice; //Price with free shipping.
            if (expressShipping)
            {
                PriceIncShipping = TotalPrice + 199; //Price with express shipping.
            }
        }
    }
}
