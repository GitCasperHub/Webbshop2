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
    public class ShowConsolesModel : PageModel
    {
        
        public List<GameConsole> consoles = ConsoleManager.GetGameConsoles();
        

        [BindProperty]
        public string Search { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }
        public void OnGet()
        {

            consoles = consoles.OrderBy(gameConsole => gameConsole.Name).ToList();

            if(Sort == "Price")
            {
                consoles = consoles.OrderBy(gameConsole => gameConsole.Price).ToList();
            }
            else if (Sort == "A2Z")
            {
                consoles = consoles.OrderBy(gameConsole => gameConsole.Name).ToList();
            }
            else if (Sort == "Z2A")
            {
                consoles = consoles.OrderByDescending(gameConsole => gameConsole.Name).ToList();
            }


        }

        public void Onpost(string id)
        {

            CartManager.AddToCart(id);
            consoles = consoles.OrderBy(gameConsole => gameConsole.Name).ToList();


            if (Search != null)
            {


                string SearchLower = Search.ToLower();
                //Search Bara Sökningar
                foreach (var console in consoles)
                {
                    consoles = consoles.Where(console => console.Name.ToLower().Contains(SearchLower)).ToList();
                }
            }

        }

       
    }
}
