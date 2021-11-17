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
    public class IndexModel : PageModel
    {
        public List<Game> games = GameManager.GetGames();
        public List<GameConsole> consoles = ConsoleManager.GetGameConsoles();
        public List<Gadget> gadgets = GadgetManager.GetGadgets();

        public void OnGet()
        {
            games = games.Where(game => game.Name.Contains("Call of Duty: Vanguard ")).ToList();
            consoles = consoles.Where(console => console.Name.Contains("Xbox Series X ")).ToList();
            gadgets = gadgets.Where(gadget => gadget.Name.Contains("SCUF Xbox Series X Controller")).ToList();

        }

        public void OnPost(string id)
        {
            


        }

    }
}
