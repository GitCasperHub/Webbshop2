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

        public string NewName { get; set; }
        public int NewPrice { get; set; }
        public int NewAgeRestriction { get; set; }
        public string NewPlatform { get; set; }
        public string NewDescription { get; set; }
        public int NewStock { get; set; }
        public string NewGenre { get; set; }
        public string NewReleaseDate { get; set; }
        public string NewStudio { get; set; }
        public double NewCriticScore { get; set; }
        public string NewImageURL { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public int AgeRestriction { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Studio { get; set; }
        public double CriticScore { get; set; }
        public string ImageURL { get; set; }



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
                //Product.AgeRestriction = NewAgeRestriction;
                //Product.Platform = NewPlatform;
                Product.Description = NewDescription;
                Product.Stock = NewStock;
                //Product.Genre = NewGenre;
                //Product.ReleaseDate = NewReleaseDate;
                //Product.Studio = NewStudio;
                //Product.CriticScore = NewCriticScore;
                Product.ImageURL = NewImageURL;




                saveChanges = false;
            }


        }
    }
}
