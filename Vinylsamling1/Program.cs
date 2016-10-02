﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling1
{
    class Program
    {
        static int userValue;

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
                Console.WriteLine("[3] Redigera arkiv");
                Console.WriteLine("[4] Avsluta");
                string choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    userValue = int.Parse(choice);
                }
                else
                {
                    Console.WriteLine("Vänligen ange 1,2,3 eller 4");
                }

                switch (userValue)
                {
                    case 1:
                        ListFunctions.PrintVinylsToScreen();
                        
                        break;

                    case 2:
                        ListFunctions.AddToList();
                        ListFunctions.SaveToDisk();
                        break;

                    case 3:
                        ListFunctions.EditVinyl();

                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:

                        break;
                }



            }

        }
        
    }
}
