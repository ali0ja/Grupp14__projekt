using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace project
{
    public class Menu
    {
        public int Choice;


        public void GetChoice()
        {
            Console.Clear();
            bool mainMenu = true;
            Choice = 0;
            while (mainMenu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("********************************");
                Console.WriteLine("Choose from these options: ");
                Console.WriteLine("1) Convert ohms law");
                Console.WriteLine("2) Convert degrees");
                Console.WriteLine("3) Convert length");
                Console.WriteLine("4) Speed = distance/time ");
                Console.WriteLine("5) Convert area/volume");
                Console.WriteLine("6) Show the latest calculation");
                Console.WriteLine("7) Exit ");
                Console.WriteLine("********************************");
                Console.WriteLine();


                while (!int.TryParse(Console.ReadLine(), out Choice) || Choice > 7 || Choice < 1)
                {
                    Console.WriteLine("Invaild number, try again");
                }
                switch (Choice)
                {
                    case 1:
                        OhmsLag om = new OhmsLag();
                        om.Getcho();

                        break;
                    case 2:
                        Degri dg = new Degri();
                        dg.GetDeg();
                        break;
                    case 3:
                        Length len = new Length();
                        len.GetVal();

                        break;
                    case 4:
                        Speed speed = new Speed();
                        speed.Getspeed();

                        break;
                    case 5:
                        AreaVol are = new AreaVol();
                        are.GetChar();
                        break;
                    case 6:
                        ReadJsonFromFile();

                        break;
                    case 7:
                        mainMenu = false;
                        break;

                }

            }

        }
        static void ReadJsonFromFile()
        {
            string jsondata = File.ReadAllText("history.json");
            List<string> obj = JsonSerializer.Deserialize<List<string>>(jsondata);
            foreach (var o in obj)
            {
                Console.WriteLine(o);
            }
        }

    }
}