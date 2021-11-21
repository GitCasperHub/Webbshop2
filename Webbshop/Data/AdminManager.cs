using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webbshop.Data;
using Webbshop.Models;

namespace Webbshop.Data
{
    public class AdminManager
    {

        

        public static void RemoveProduct(string removeId)
        {
            GameManager.Games.RemoveAll(product => product.Id.Contains(removeId));
            GameManager.AddedGames.RemoveAll(product => product.Id.Contains(removeId));
            ConsoleManager.Consoles.RemoveAll(product => product.Id.Contains(removeId));
            //ConsoleManager.AddedConsoles.RemoveAll(product => product.Id.Contains(removeId));
            GadgetManager.Gadgets.RemoveAll(product => product.Id.Contains(removeId));
            //GadgetManager.AddedGadgets.RemoveAll(product => product.Id.Contains(removeId));
            CartManager.CartList.RemoveAll(product => product.Id.Contains(removeId));

        }

    }
}
