using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Models
{

    //Properties som används för Game & GameManager
    public class Game : Product
    {
        

      
        public int AgeRestriction { get; set; }
        public string Platform { get; set; }       
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Studio { get; set; }
        public double CriticScore { get; set; }

    }
   
}

