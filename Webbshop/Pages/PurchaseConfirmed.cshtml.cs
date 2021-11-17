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

    public class PurchaseConfirmedModel : PageModel
    {
        public List<Product> OrderList = CartManager.CartList;

        public void OnGet()
        {

        }
    }
}
