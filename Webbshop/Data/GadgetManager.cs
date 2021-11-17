using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class GadgetManager
    {
        public static List<Gadget> Gadgets { get; set; }

        private static string GenerateGadgetId()
        {
            string id = "GT" + Math.Abs(Guid.NewGuid().GetHashCode());
            return id;
        }

        public static List<Gadget> GetGadgets()
        {
            if (Gadgets == null || !Gadgets.Any())
            {
                Gadgets = new List<Gadget>
                {
                    new Gadget()
                    {
                        Id = GenerateGadgetId(),
                        Name = "PlayStation 5 Controller",
                        Price = 629,
                        Stock = 10,
                        GadgetPlatform = "PlayStation 5",
                        ImageURL = "https://www.mytrendyphone.se/images/Sony-PlayStation-5-DualSense-Wireless-Controller-23122020-White-0711719399506-01-p.jpg",
                        Description = "The DualSense™ wireless controller offers immersive haptic feedback1, " +
                        "dynamic adaptive triggers and a built-in microphone, all integrated into an iconic comfortable design."

                    },
                     new Gadget()
                    {
                        Id = GenerateGadgetId(),
                        Name = "PlayStation 4 Controller",
                        Price = 649,
                        Stock = 13,
                        GadgetPlatform = "PlayStation 4",
                        ImageURL = "https://www.pricerunner.se/product/1200x630/1554043887/Sony-DualShock-4-Wireless-Controller-Black.jpg",
                        Description = "The Wireless PlayStation 4 Controller is one of Sonys most comfortable controllers ever"

                    },
                      new Gadget()
                    {
                        Id = GenerateGadgetId(),
                        Name = "SCUF Xbox Series X Controller",
                        Price = 2000,
                        Stock = 4,
                        GadgetPlatform = "Xbox Series X & Xbox One",
                        ImageURL = "https://scufgaming.com/media/prismic/71b5c986-76fd-4182-b7de-31d3c8ad2234_instinct_base_shadow_xbox_series_x_controller_850x600.png",
                        Description = "Custome Made Wireless Controller for Primarly Xbox Series X. " +
                        "Adds a competitive edge with non-slip performance grip and instant triggers." +
                        "Works with Xbox One because of backward compatibility."

                    },
                       new Gadget()
                    {
                        Id = GenerateGadgetId(),
                        Name = "Xbox One Controller",
                        Price = 550,
                        Stock = 15,
                        GadgetPlatform = "Xbox Series X & Xbox One",
                        ImageURL = "https://www.pricerunner.se/product/1200x630/1752541419/Microsoft-Xbox-One-Wireless-Controller-White.jpg",
                        Description = "Wireless Xbox One Controller, forward compatibility so it works with Xbox Series X aswell."

                    },
                        new Gadget()
                    {
                        Id = GenerateGadgetId(),
                        Name = "Branch Outlet 6-way",
                        Price = 99,
                        Stock = 25,
                        GadgetPlatform = "Works for all Platforms",
                        ImageURL = "https://www.netonnet.se/GetFile/ProductImagePrimary/hem-fritid/el-batterier/grenuttag/on-extension-lead-6-way-grounded-with-switch-1-5m(1003909)_325892_1_Normal_Large.jpg",
                        Description = "Branch Outlet with 6-way extension and ON/OFF switch"

                    },

                };



            }


            return Gadgets;
        }

    }
}


