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
        public List<Game> Games = GameManager.GetGames();

        

        [BindProperty]
        public string Search { get; set; }
        

        
        [BindProperty(SupportsGet = true)]

        //Property för Sortering
        public string Sort { get; set; }
       
        public void OnGet()
        {
            Games = Games.OrderBy(game => game.Name).ToList();



            //Sortering Via Price
            if (Sort == "Price")
            {
                Games = Games.OrderBy(game => game.Price).ToList();
            }
            //Sortering A till Z
            else if (Sort == "A2Z")
            {
                Games = Games.OrderBy(game => game.Name).ToList();
            }
            //Sortering Z till A
            else if (Sort == "Z2A")
            {
                Games = Games.OrderByDescending(game => game.Name).ToList();
            }

          

        }

        public void OnPost(string id)
        {
            

            CartManager.AddToCart(id);
            Games = Games.OrderBy(game => game.Name).ToList();

            if (Search != null)
            {
                string SearchLower = Search.ToLower();



                //Search Bar sökningar
                if (SearchLower == "playstation")
                {

                    Games = Games.Where(game => game.Platform.Contains("Playstation")).ToList();
                }
                else if (SearchLower == "xbox one")
                {

                    Games = Games.Where(game => game.Platform.Contains("Xbox One")).ToList();

                }
                else if (SearchLower == "electronic arts")
                {
                    Games = Games.Where(game => game.Studio.Contains("Electronic Arts")).ToList();

                }
                else if (SearchLower == "activision")
                {
                    Games = Games.Where(game => game.Studio.Contains("Activision")).ToList();

                }
                else if (SearchLower == "wii")
                {
                    Games = Games.Where(game => game.Platform.Contains("Wii")).ToList();

                }
            }
        }
    }
}
