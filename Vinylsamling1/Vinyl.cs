using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling1
{
    class Vinyl
    {
        

        public string Name { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Year { get; set; }

/*
         public static string name;

         public static string Name
         {
             get { return name; }
             set { name = value; }
         }
         public static string album;

         public static string Album
         {
             get { return album; }
             set { album = value; ; }
         }

         public static string artist;

         public static string Artist
         {
             get { return artist; }
             set { artist = value; }
         }
         public static string year;

         public static string Year
         {
             get { return year; }
             set { year = value; }
         }
         */
        
         
         public Vinyl(string name, string album, string artist, string year)
         {
             Name = name;
             Album = album;
             Artist = artist;
             Year = year;
         }
         
    }
}
