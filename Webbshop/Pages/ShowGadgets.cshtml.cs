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
    public class ShowGadgetsModel : PageModel
    {

        public List<Gadget> gadgets = GadgetManager.GetGadgets();

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }

        public void OnGet()
        {



            gadgets = gadgets.OrderBy(Gadget => Gadget.Name).ToList();

            if (Sort == "Price")
            {
                gadgets = gadgets.OrderBy(Gadget => Gadget.Price).ToList();
            }
            else if (Sort == "A2Z")
            {
                gadgets = gadgets.OrderBy(Gadget => Gadget.Name).ToList();
            }
            else if (Sort == "Z2A")
            {
                gadgets = gadgets.OrderByDescending(Gadget => Gadget.Name).ToList();
            }


        }

        public void OnPost(string id)
        {
            CartManager.AddToCart(id);
            gadgets = gadgets.OrderBy(Gadget => Gadget.Name).ToList();


        }
    }
}
