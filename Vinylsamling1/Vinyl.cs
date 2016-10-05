using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling1
{
    class Vinyl
    {
        

        public  string Name { get; set; }
        public  string Album { get; set; }
        public  string Artist { get; set; }
        public  string Year { get; set; }


       
         
         public Vinyl(string name, string album, string artist, string year)
         {
             Name = name;
             Album = album;
             Artist = artist;
             Year = year;
         }

        
    }
}
