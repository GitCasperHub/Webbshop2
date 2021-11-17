using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshop.Data;
using Webbshop.Models;

namespace Webbshop.Pages
{
    [BindProperties]
    public class AdminAddGameModel : PageModel
    {

        public List<Game> PendingGames = GameManager.AddedGames; 

        public bool AddToPendingList { get; set; } = false;
        public bool MergeLists { get; set; } = false;

        public string IdentID { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public int AgeRestriction { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool InStock { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Studio { get; set; }
        public double CriticScore { get; set; }
        public string ImageURL { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(bool addToPendingList, bool mergeLists)
        {
            MergeLists = mergeLists;
            AddToPendingList = addToPendingList;

            if (addToPendingList)
            {
                //Lägger till spel i pending listan
                Data.GameManager.NewGame(Name, Price, AgeRestriction, Platform, Description, Stock, Genre, ReleaseDate, Studio, CriticScore, ImageURL);
                addToPendingList  = false;
            }
            if (mergeLists)
            {
                // Slår ihop pending listan 
                Data.GameManager.AddNewGameList();
                mergeLists = false;
            }
        }
    }
}
