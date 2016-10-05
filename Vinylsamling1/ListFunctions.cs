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

        public static void SaveToDisk() // Metod för att spara ner det användaren skrivit in till textfilerna
        {
            string[] saveToFile = new string[vinyls.Count * 4];
            for (int i = 0; i < vinyls.Count; i+=4)
            {
                saveToFile[i] = vinyls[i].Name;
                saveToFile[i+1] = vinyls[i].Album;
                saveToFile[i+2] = vinyls[i].Artist;
                saveToFile[i+3] = vinyls[i].Year;
            }
            File.WriteAllLines(@"C:\Users\public\Vinyls.txt", saveToFile);
        }

        public static void PrintVinylsToScreen() // Skriver ut vinylerna till användaren.
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



        
        public static void EditVinyl()
        {
            PrintVinylsToScreen();
            Console.WriteLine("\nAnge vilken vinyl du vill ta bort");
            Console.Write("Val: ");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            choice1--;            
            vinyls.RemoveAt(choice1);
            PrintVinylsToScreen();
            Console.ReadKey();
            
            
            



        }
        
    }
}

    


