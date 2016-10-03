using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling1
{
    class Vinyl
    {
        public static List<Vinyl> vinyls = new List<Vinyl>();

        private static string name;

        public string Name
        {
            get { return name; }
            set { name = Console.ReadLine(); }
        }
        private static string album;

        public static string Album
        {
            get { return album; }
            set { album = Console.ReadLine(); }
        }

        private static string artist;

        public static string Artist
        {
            get { return artist; }
            set { artist = Console.ReadLine(); }
        }
        private static string year;

        public static string Year
        {
            get { return year; }
            set { year = Console.ReadLine(); }
        }

       

        public Vinyl(string name, string album, string artist, string year)
        {
            Name = name;
            Album = album;
            Artist = artist;
            Year = year;
        }
    }
}
