using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class CartManager
    {
        public static List<Product> AllProductsList = new List<Product>();
        public static List<Product> CartList = new List<Product>();

        // general
        public static double TotalPrice { get; set; }
        public static int Moms { get; set; }
        public static int RemoveCart { get; set; }
        public static bool ClearCart { get; set; }

        public static List<Product> GetAllProducts()
        {
            AllProductsList.Clear();

            foreach (Gadget gadget in GadgetManager.GetGadgets())
            {
                AllProductsList.Add(gadget);
            }
            foreach (Game game in GameManager.GetGames())
            {
                AllProductsList.Add(game);
            }
            foreach (GameConsole console in ConsoleManager.GetGameConsoles())
            {
                AllProductsList.Add(console);
            }

            return AllProductsList;
        }

        public static void AddToCart(string id)
        {
            List<Product> allProducts = GetAllProducts();


            TotalPrice = 0;
            foreach( var product in CartList)
            {
                TotalPrice += product.Price;

            }


            for (int i = allProducts.Count - 1; i > 0; i--)
            {
                if (allProducts[i].Id == id)
                {
                    CartList.Add(allProducts[i]);
                    
                    break;
                }
            }


        }
        public static void RemoveFromCart(string removeId)
        {

            for (int i = CartList.Count - 1; i >= 0; i--)
            {
                if (CartList[i].Id == removeId)
                {
                    TotalPrice -= CartList[i].Price;
                    CartList.Remove(CartList[i]);
                }
            }
        }
    }
}
