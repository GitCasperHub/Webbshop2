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
    public class EditProductModel : PageModel
    {

        List<Product> allProducts = CartManager.GetAllProducts();

        public string SearchId { get; set; } = null;
        public bool IdMatch { get; set; }
        public Product Product { get; set; }
        public Game Game { get; set; }
        public GameConsole Console { get; set; }
        public Gadget Gadget { get; set; }

        public string NewName { get; set; }
        public int NewPrice { get; set; }
        public string NewDescription { get; set; }
        public int NewStock { get; set; }
        public string NewImageURL { get; set; }

        //Game specific properties
        public int NewAgeRestriction { get; set; }
        public string NewPlatform { get; set; }
        public string NewGenre { get; set; }
        public string NewReleaseDate { get; set; }
        public string NewStudio { get; set; }
        public double NewCriticScore { get; set; }

        //Console specific properties
        public string NewConsoleDeveloper { get; set; }
        public string NewConsoleRelease { get; set; }

        //Gadget specific properties
        public string NewGadgetPlatform { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int AgeRestriction { get; set; }
        public string Platform { get; set; }
        public string ImageURL { get; set; }

        //Game specific properties
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Studio { get; set; }
        public double CriticScore { get; set; }

        //Console specific properties
        public string ConsoleDeveloper { get; set; }
        public string ConsoleRelease { get; set; }

        //Gadget specific properties
        public string GadgetPlatform { get; set; }

        public void OnGet()
        {

        }

        public void OnPost(bool saveChanges)
        {
            IdMatch = false;

            foreach (var product in allProducts)
            {
                if (product.Id == SearchId)
                {
                    IdMatch = true;
                    Product = product;

                }
            }

            if (saveChanges)
            {

                Product.Name = NewName;
                Product.Price = NewPrice;
                Product.Description = NewDescription;
                Product.Stock = NewStock;
                Product.ImageURL = NewImageURL;

                if (SearchId.Substring(0,2) == "GE" )
                {
                    Game = (Game)Product;
                    Game.AgeRestriction = NewAgeRestriction;
                    Game.Platform = NewPlatform;
                    Game.Genre = NewGenre;
                    Game.ReleaseDate = NewReleaseDate;
                    Game.Studio = NewStudio;
                    Game.CriticScore = NewCriticScore;
                }
                else if(SearchId.Substring(0, 2) == "CE")
                {
                    Console = (GameConsole)Product;
                    Console = (GameConsole)Product;
                    Console.ConsoleDeveloper = NewConsoleDeveloper;
                    Console.ConsoleRelease = NewConsoleRelease;
                }
                else
                {
                    Gadget = (Gadget)Product;
                    Gadget = (Gadget)Product;
                    Gadget.GadgetPlatform = NewGadgetPlatform;
                }


                saveChanges = false;
            }


        }
    }
}
