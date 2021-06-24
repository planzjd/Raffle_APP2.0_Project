using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Raffle_APP_Project
{
    class Program
    {

        ////-------Main Method----------------
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Party!");
            GetUserInfo();
            PrintGuestsName();
            PrintWinner();
        }
        //------Variables------------
        private static Dictionary<int, string> guests = new Dictionary<int, string>();
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();

        private static string message1 = "Please enter your name: ";
        private static string message2 = "Do you want to add another name? ";

        //-------Method 1-------------
        private static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string user = Console.ReadLine();

            return user;
        }

        //------Method 2-------------
        private static void GetUserInfo()
        {
            string name;
            string otherGuests;

            do
            {
                name = GetUserInput(message1);
                raffleNumber = GenerateRandomNumber(min, max);

                AddGuestInRaffle(raffleNumber, name);
                otherGuests = GetUserInput(message2);

            }
            while (otherGuests.ToLower() == "yes");

        }

        ////--------Method 3-------------
        private static int GenerateRandomNumber(int min, int max)
        {
            int randomNum = _rdm.Next(min, max);
            return randomNum;
        }

        ////--------Method 4------------

        private static void AddGuestInRaffle(int raffleNumber, string guest)
        {
            guests.Add(raffleNumber, guest);
        }

        ////--------Method 5-----------
        private static void PrintGuestsName()
        {
            foreach (var kvp in guests)
            {
                Console.WriteLine(kvp);
            }
        }

        ////--------Method 6-----------
        private static int GetRaffleNumber(Dictionary<int, string> guests)
        { 
        int index = _rdm.Next(guests.Count);
        int key = guests.Keys.ElementAt(index);
        return key;

        }

        ////--------Method 7----------
        private static void PrintWinner()
        {

            int winnerNumber = GetRaffleNumber(guests);
            string winnerName = guests[winnerNumber];
            Console.WriteLine($"The Winner is: {winnerName} with the #{winnerNumber}");
        }

        







        //static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        //{
        //    var counter = 0;
        //    for (int i = 0; i < 30; i++)
        //    {
        //        Console.Clear();

        //        switch (counter % 4)
        //        {
        //            case 0:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║    │││ \\   ║");
        //                    Console.WriteLine("         ║    │││  O  ║");
        //                    Console.WriteLine("         ║    OOO     ║");
        //                    break;
        //                };
        //            case 1:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    OOOO    ║");
        //                    break;
        //                };
        //            case 2:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║   / │││    ║");
        //                    Console.WriteLine("         ║  O  │││    ║");
        //                    Console.WriteLine("         ║     OOO    ║");
        //                    break;
        //                };
        //            case 3:
        //                {
        //                    Console.WriteLine("         ╔════╤╤╤╤════╗");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    ││││    ║");
        //                    Console.WriteLine("         ║    OOOO    ║");
        //                    break;
        //                };
        //        }

        //        counter++;
        //        Thread.Sleep(200);

        //bool guestName = true;
        //int guestNameCount = 0;

        //while (guestName)
        //{
        //    Console.WriteLine(message2);
        //    string answer = Console.ReadLine();
        //    if (answer.ToLower() == "yes")

        //    {
        //        Console.WriteLine(message1);
        //        Console.ReadLine();
        //        guestNameCount++;
        //    }
        //    else
        //    {
        //        guestName = false;
        //    }
        //}
        //    }
        //}
    }
}


