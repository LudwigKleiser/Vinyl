using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Vinylsamling1
{
    class ListFunctions
    {
        //Här skapas listorna vi ska använda oss av
        public static List<string> name = new List<string>();
        public static List<string> album = new List<string>();
        public static List<string> artist = new List<string>();
        public static List<string> year = new List<string>();


        // Denna metod körs bara en gång för att kolla om det redan finns en fil, finns det ingen fil så skapar den en ny.
        // Finns det redan en fil så lägger den in datan från filerna till listorna.


        public static void ListApplier()
        {

            if (File.Exists(@"C:\Users\public\Name.txt") &&
             File.Exists(@"C:\Users\public\Album.txt") &&
             File.Exists(@"C:\Users\public\Artist.txt") &&
             File.Exists(@"C:\Users\public\Year.txt"))
            {
                // Här läggs datan från filerna in i listorna.
                var readFromNames = File.ReadAllLines(@"c:\users\public\Name.txt");
                foreach (var s in readFromNames)
                {
                    name.Add(s);


                }

                // https://www.dotnetperls.com/remove-duplicates-list tar bort du
                List<string> distinct = name.Distinct().ToList();
                name = distinct;





                var readFromAlbum = File.ReadAllLines(@"c:\users\public\Album.txt");
                foreach (var s in readFromAlbum)
                {
                    album.Add(s);


                }

                List<string> distinct1 = album.Distinct().ToList();
                album = distinct1;

                var readFromArtist = File.ReadAllLines(@"c:\users\public\Artist.txt");
                foreach (var s in readFromArtist)
                {
                    artist.Add(s);


                }
                List<string> distinct2 = artist.Distinct().ToList();
                artist = distinct2;

                var readFromYear = File.ReadAllLines(@"c:\users\public\Year.txt");
                foreach (var s in readFromYear)
                {
                    year.Add(s);

                }
                List<string> distinct3 = year.Distinct().ToList();
                year = distinct3;
                SaveToDisk();

            }

            else
            {
                // Skapar en tom textfil i mappen. Använder man bara create så är filen fortfarande öppen vilket gör att man inte kan gå in i den igen senare i programmet.
                // Jag använder därför Dispose för att stänga den igen så att vi kommer in i den senare i programmet.
                File.Create(@"C:\Users\public\Name.txt").Dispose();
                File.Create(@"C:\Users\public\Album.txt").Dispose();
                File.Create(@"C:\Users\public\Artist.txt").Dispose();
                File.Create(@"C:\Users\public\Year.txt").Dispose();
                Console.WriteLine("Skapar filer.....");
                Console.WriteLine("Tryck på valfri knapp för att komma till menyn");
                Console.ReadKey();
            }


        }



        public static void AddToList() // Metod för att ta in användarens input in i listorna
        {
            Console.WriteLine("Skriv in namnet");
            Console.Write("Namn: ");
            string tempName = Console.ReadLine();
            name.Add(tempName);

            Console.WriteLine("Skriv in albumet");
            Console.Write("Album: ");
            string tempAlbum = Console.ReadLine();
            album.Add(tempAlbum);

            Console.WriteLine("Skriv in artisten");
            Console.Write("Artist: ");
            string tempArtist = Console.ReadLine();
            artist.Add(tempArtist);


            Console.WriteLine("Skriv in året");
            Console.Write("år: ");
            string tempYear = Console.ReadLine();
            year.Add(tempYear);

        }

        public static void SaveToDisk() // Metod för att spara ner det användaren skrivit in till textfilerna
        {
            File.WriteAllLines(@"C:\Users\public\Name.txt", name);
            File.WriteAllLines(@"C:\Users\public\Album.txt", album);
            File.WriteAllLines(@"C:\Users\public\Artist.txt", artist);
            File.WriteAllLines(@"C:\Users\public\Year.txt", year);
        }

        public static void PrintVinylsToScreen() // Skriver ut vinylerna till användaren.
        {
            if (!name.Any()) 
            {
                Console.WriteLine("Det finns inga vinyler i arkviet än!");
                Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                Console.Read();
                
            }

            else
            { 
            int x = 1;
            Console.Clear();

            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine("\n [{0}]", x);
                Console.WriteLine("Namn: {0}", name[i]);
                Console.WriteLine("Album: {0}", album[i]);
                Console.WriteLine("Artist: {0}", artist[i]);
                Console.WriteLine("År: {0}", year[i]);
                x++;
            }
             }
            
            
        }

          public static void EditVinyl()
        {
            PrintVinylsToScreen();
            Console.WriteLine("\nAnge vilken vinyl du vill redigera");
            Console.Write("Val: ");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            choice1--;
            name.RemoveAt(choice1);
            album.RemoveAt(choice1);
            artist.RemoveAt(choice1);
            year.RemoveAt(choice1);
            SaveToDisk();
            PrintVinylsToScreen();
            




        }

    }
}

