using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling1
{
    class Program
    {
        

        static void Main(string[] args)
        {
          ListFunctions.ListApplier();
            bool start = true;
            while (start)
            {
                Console.Clear();
                Console.WriteLine("Hej och välkommen till din vinylsamling");
                Console.WriteLine("[1] Visa vinyl arkivet");
                Console.WriteLine("[2] Lägg till i arkivet");
                Console.WriteLine("[3] Redigera vinyler");
                Console.WriteLine("[4] Rensa i arkivet");
                Console.WriteLine("[5] Avsluta");
                Console.Write("Val: ");
                int userValue;
                int.TryParse(Console.ReadLine(), out userValue);
               
              

                switch (userValue)
                {
                    case 1:
                        ListFunctions.PrintVinylsToScreen();
                        Console.ReadLine();                      
                        break;

                    case 2:
                        ListFunctions.AddToList();
                        ListFunctions.SaveToDisk();
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        ListFunctions.RemoveVinyl();
                        ListFunctions.SaveToDisk();
                        break;

                    case 5:
                         Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Någonting gick fel, tryck på valfri knapp för att återgå till menyn");
                        Console.ReadKey();
                       

                        break;
                }



            }

        }
        
    }
}
