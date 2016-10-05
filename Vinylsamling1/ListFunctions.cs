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
       public static List<Vinyl> vinyls = new List<Vinyl>();
        
        

        // Denna metod körs bara en gång för att kolla om det redan finns en fil, finns det ingen fil så skapar den en ny.
        // Finns det redan en fil så lägger den in datan från filerna till listan.

        public static void ListApplier()
        {

            string[] readFromFile;
            try
            {
                readFromFile = File.ReadAllLines(@"C:\Users\public\Vinyls.txt");
            }
            catch (FileNotFoundException)
            {
                File.Create(@"C:\Users\public\Vinyls.txt").Dispose();
                readFromFile = File.ReadAllLines(@"C:\Users\public\Vinyls.txt");

            }

            for (int i = 0; i < readFromFile.Length; i += 4)
            {
                vinyls.Add(new Vinyl(readFromFile[i], readFromFile[i + 1], readFromFile[i + 2], readFromFile[i + 3]));
            }

            


        }
        


        public static void AddToList() // Metod för att ta in användarens input in i listorna
        {

            
            
            Console.Write("Namn: ");
            string name = Console.ReadLine();
           
           

            Console.Write("Album: ");
            string album =  Console.ReadLine();
            
           

            Console.Write("Artist: ");
            string artist = Console.ReadLine();
            
            

            Console.Write("År: ");
            string year = Console.ReadLine();

            vinyls.Add(new Vinyl(name, album, artist, year));
           
            
        }

        public static void SaveToDisk() // Metod för att spara ner det användaren skrivit in till textfilen
        {
            string[] saveToFile = new string[vinyls.Count * 4];
            for (int i = 0; i < vinyls.Count; i++)
            {
                saveToFile[i*4] = vinyls[i].Name;
                saveToFile[i*4 + 1] = vinyls[i].Album;
                saveToFile[i*4 + 2] = vinyls[i].Artist;
                saveToFile[i*4 + 3] = vinyls[i].Year;
            }
            File.WriteAllLines(@"C:\Users\public\Vinyls.txt", saveToFile);
        }
        // Kollar först om våran lista innehåller någonting, gör den inte det så ger den ett felmeddelande för att förbättra användar upplevelsen.
        // Innehåller våran lista någonting så skriver den ut vinylerna till användaren.
        public static void PrintVinylsToScreen() 
        {
            if (!vinyls.Any()) 
            {
                Console.WriteLine("Det finns inga vinyler i arkviet än!");
                Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                Console.ReadKey();
                
                
            }
            
            int x = 1;
            foreach (Vinyl vinyl in vinyls)
            {
                Console.WriteLine("[{0}] Namn: {1} Album: {2} Artist: {3} År: {4}", x, vinyl.Name, vinyl.Album, vinyl.Artist, vinyl.Year);
                x++;
                
            }
            
        }



        
        public static void RemoveVinyl()
        {
            PrintVinylsToScreen();
            Console.WriteLine("\nAnge vilken vinyl du vill ta bort");
            Console.Write("Val: ");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            choice1--;            
            vinyls.RemoveAt(choice1);
            PrintVinylsToScreen();
            SaveToDisk();
            Console.ReadKey();
        }
        // Tar emot användarens input från från DecideOnEdit() och ger användaren möjlighet att redigera den valda vinylel.
        public static void EditVinyl(Vinyl vinyl)
        {
            Console.WriteLine("Ange nytt namn(klicka på enter för att inte göra ändring.");
            Console.Write("Namn: ");
            string newName = Console.ReadLine();
            if (newName != "") vinyl.Name = newName;

            Console.WriteLine("Ange nytt album(klicka på enter för att inte göra ändring.");
            Console.Write("Album: ");
            string newAlbum = Console.ReadLine();
            if (newAlbum != "") vinyl.Album = newName;

            Console.WriteLine("Ange ny Artist(klicka på enter för att inte göra ändring.");
            Console.Write("Artist: ");
            string newArtist = Console.ReadLine();
            if (newArtist != "") vinyl.Artist = newArtist;

            Console.WriteLine("Ange nytt år(klicka på enter för att inte göra ändring.");
            Console.Write("År: ");
            string newYear = Console.ReadLine();
            if (newYear != "") vinyl.Year = newYear;


        }
        // Ber användaren välja vilken vinyl som ska redigeras. Den kallar sedan på EditVinyl() och skickar med användarens input.
        public static void DecideOnEdit()
        {
            
            PrintVinylsToScreen();
            Console.WriteLine("Ange vilket vinyl du vill redigera");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            choice1--;
            if (choice1 < vinyls.Count && choice1 >= 0)
            {
            EditVinyl(vinyls[choice1]); 
            }
           
           
        }
    }
}

    


