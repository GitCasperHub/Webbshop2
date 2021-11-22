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
    public class ShowGamesModel : PageModel
    {
        public List<Game> games = GameManager.GetGames();

        

        [BindProperty]
        public string Search { get; set; }
        

        
        [BindProperty(SupportsGet = true)]

        //Property för Sortering
        public string Sort { get; set; }
       
        public void OnGet()
        {
            games = games.OrderBy(game => game.Name).ToList();



            //Sortering Via Price
            if (Sort == "Price")
            {
                games = games.OrderBy(game => game.Price).ToList();
            }
            //Sortering A till Z
            else if (Sort == "A2Z")
            {
                games = games.OrderBy(game => game.Name).ToList();
            }
            //Sortering Z till A
            else if (Sort == "Z2A")
            {
                games = games.OrderByDescending(game => game.Name).ToList();
            }

          

        }

        public void OnPost(string id)
        {
            

            CartManager.AddToCart(id);
            games = games.OrderBy(game => game.Name).ToList();

            if (Search != null)
            {
                string SearchLower = Search.ToLower();

                //Search Bar sökningar

                foreach(var game in games)
                {
                    games = games.Where(game => game.Name.ToLower().Contains(SearchLower)).ToList();
                }

            }
        }
    }
}
