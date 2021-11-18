using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class GameManager
    {

        public static List<Game> Games { get; set; } = new List<Game>();
        public static List<Game> AddedGames { get; set; } = new List<Game>();

        private static string GenerateGameId()
        {
            string id = "GE" + Math.Abs(Guid.NewGuid().GetHashCode());
            return id;
        }

        public static List<Game> GetGames()
        {
            if (Games == null || !Games.Any())
            {

                Games = new List<Game>
                {


                    new Game()
                    {
                        Id = GenerateGameId(),
                        Name = "FIFA 22 ",
                        Price = 599,
                        AgeRestriction = 13,
                        Platform = "Playstation 4 & 5, PC, Xbox One, Xbox Series X, Nintendo Switch",
                        Description = "FIFA 22 is an association football simulation video game published by " +
                        "Electronic Arts as part of the FIFA series. It is the 29th installment in the FIFA series ",
                        Stock = 10,

                        Genre = "Sportspel, Simulationsdatorspel, fotbollsspel, Simulationsträning ",
                        ReleaseDate = "1/10/2021",
                        Studio = "Electronic Arts ",
                        CriticScore = 7,
                        ImageURL = "https://cdn.insidesport.co/wp-content/uploads/2021/07/12192307/dfzhhzs.jpg"

                    },
                     new Game()
                    {
                        Id = GenerateGameId(),
                        Name = "Call of Duty: Vanguard ",
                        Price = 599,
                        AgeRestriction = 13,
                        Platform = "Playstation 4 & 5, PC, Xbox One, Xbox Series X",
                        Description = "The award-winning Call of Duty® series returns with Call of Duty®: Vanguard," +
                        " in which players will experience influential battles of World War II as they fight for " +
                        "victory across the Eastern and Western Fronts of Europe, the Pacific, and North Africa. ",
                        Stock = 10,

                        Genre = "First-Person Shooter",
                        ReleaseDate = "5/11/2021",
                        Studio = "Activision ",
                        CriticScore = 6,
                        ImageURL = "https://s2.gaming-cdn.com/images/products/9841/orig/call-of-duty-vanguard-xbox-one-xbox-one-game-microsoft-store-europe-cover.jpg"

                    },
                      new Game()
                    {
                        Id = GenerateGameId(),
                        Name = "Transformers: The Game ",
                        Price = 199,
                        AgeRestriction = 6,
                        Platform = "Playstation 2 & 3, PC, Xbox 360, Nintendo DS, Wii",
                        Description = "Transformers: The Game is an action-adventure video game based on the 2007 live-action film Transformers." +
                        " The game closely follows the story of the film, depicting the Autobots and Decepticons' arrival on Earth" +
                        " following a war between them that has ravaged their home planet of Cybertron. ",
                        Stock = 5,

                        Genre = "Third-Person Shooter ",
                        ReleaseDate = "19/7/2007",
                        Studio = "Activision",
                        CriticScore = 9.5,
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/9/94/Transformers_-_The_Game_Coverart.png"

                    },
                      new Game()
                      {
                          Id = GenerateGameId(),
                          Name = "Grand Theft Auto V",
                          Price = 100,
                          AgeRestriction = 17,
                          Platform = "Playstation 3, 4 & 5, PC, Xbox 360",
                          Description = "Grand Theft Auto V is an action-adventure game played from either a third-person or first-person perspective. " +
                          "Players complete missions—linear scenarios with set objectives—to progress through the story. " +
                          "Outside of the missions, players may freely roam the open world.",
                          Stock = 15,
                          Genre = "Action-Adventure, First/Third-Person Shooter & non-linear game",
                          ReleaseDate = "17/9/2013",
                          Studio = "Rockstar Games & Rockstar North",
                          CriticScore = 9.5,
                          ImageURL = "https://cdn-products.eneba.com/resized-products/t0zqmqhdcxppyol3mtlg_350x200_1x-0.jpg",


                      },
                        new Game()
                      {
                          Id = GenerateGameId(),
                          Name = "Star Wars: Battlefront II Classic",
                          Price = 99,
                          AgeRestriction = 12,
                          Platform = "Playstation Portable, Playstation 2, Xbox, PC",
                          Description = "Join the rise of Darth Vader’s elite 501st Legion of Stormtroopers as you fight through an all new story-based saga " +
                          "where every action you take impacts the battlefront and, ultimately, the fate of the Star Wars galaxy.",
                          Stock = 7,
                          Genre = "Third-Person Shooter",
                          ReleaseDate = "31/10/2005",
                          Studio = "Pandemic Studios",
                          CriticScore = 9.7,
                          ImageURL = "https://img.g2a.com/323x433/1x1x0/star-wars-battlefront-2-classic-2005-steam-key-europe/59ba5d40ae653a591a391d34",


                      }



                };
                
                //NewGame("Spyro", 100, 3, "Lite text om spelet", 10, "action", "25/3/2002", "Activision", 9, "https://upload.wikimedia.org/wikipedia/en/5/53/Spyro_the_Dragon.jpg");
            }

            return Games;
        }



        public static void NewGame(string name, double price, int ageRestriciton, string platform, string description, int stock,
        string genre, string releaseDate, string studio, double critScore, string imgURL)
        {

            Game game = new Game(); //Skapar nytt spelobjekt med nedanstående attribut

            game.Id = GenerateGameId();
            game.Name = name;
            game.Price = price;
            game.AgeRestriction = ageRestriciton;
            game.Platform = platform;
            game.Description = description;
            game.Stock = stock;
            game.Genre = genre;
            game.ReleaseDate = releaseDate;
            game.Studio = studio;
            game.CriticScore = critScore;
            game.ImageURL = imgURL;

            AddedGames.Add(game); //Lägger till spel i lista

        }

        public static void AddNewGameList()
        {
            GetGames();

            foreach (var addedGame in AddedGames)
            {
                Games.Add(addedGame); //Lägger till spel i lista
            }
        }

        public static void RemovePendingGame(string removeId)
        {
            for (int i = AddedGames.Count - 1; i >= 0; i--)
            {
                if (AddedGames[i].Id == removeId)
                {
                    AddedGames.Remove(AddedGames[i]);
                }
            }
        }
    }
}