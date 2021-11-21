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
    public class AdminAddGadgetModel : PageModel
    {

        public List<Gadget> PendingGadgets = GadgetManager.AddedGadgets; 

        public bool AddToPendingList { get; set; } = false;
        public bool MergeLists { get; set; } = false;

        public string IdentID { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageURL { get; set; }
        public string GadgetPlatform { get; set; }
        public void OnGet(string removeId)
        {

            if (removeId != null)
            {
                Data.AdminManager.RemoveProduct(removeId);
                removeId = null;
            }

        }

        public void OnPost(bool addToPendingList, bool mergeLists)
        {
            MergeLists = mergeLists;
            AddToPendingList = addToPendingList;

            if (addToPendingList)
            {
                //Lägger till spel i pending listan
                Data.GadgetManager.NewGadget(Name, Price, Description, Stock, ImageURL, GadgetPlatform);

                addToPendingList  = false;
            }
            if (mergeLists)
            {
                // Slår ihop pending listan 
                Data.GadgetManager.AddNewGadgetList();
                Data.GadgetManager.AddedGadgets.Clear();
                mergeLists = false;
            }
        }
    }
}
