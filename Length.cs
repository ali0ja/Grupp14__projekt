using System;

namespace project
{
    public class Length
    {
        
            History history = new History();
            string print;
        public void GetVal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Choose from these to convert from:");
            Console.WriteLine("1) Meter ");
            Console.WriteLine("2) Centimeter");
            Console.WriteLine("3) Foot");
            Console.WriteLine("4) Tum ");
            Console.WriteLine("5) Yards");
            double Cho;
            while (!double.TryParse(Console.ReadLine(), out Cho) || Cho > 5 || Cho < 1)
            {
                Console.WriteLine("Invalid number, try again.");
            }

            if (Cho == 1 )
            {
                Console.WriteLine("Input to convert meter! ");
                double met;
                while (!double.TryParse(Console.ReadLine(), out met))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double cent = met * 100d;
                double fot = met / 3.2808;
                double tum = met / 39.37;
                double yards = met * 1.0936;                
                print = string.Format("{0} meter are {1:0.00} centimeter. {2:0.00} fot. {3:0.00}  tum. {4:0.00} yards.", met, cent, fot, tum, yards);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine(); 
            }
            
            else if (Cho == 2)
            {
                Console.WriteLine("Input to convert centimeter!");
                double cent;

                while (!double.TryParse(Console.ReadLine(), out cent))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double met = cent / 100;
                double fot = cent * 0.032808;
                double tum = cent * 0.3937;
                double yards = cent * 0.010936;
                print = string.Format("{0} centimeter are {1:0.00} meter. {2:0.00} fot. {3:0.00} tum .{4:0.00} yards", cent, met, fot, tum, yards);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine(); 
            }
            
            else if (Cho == 3 )
            {
                Console.WriteLine("Input to convert foot! ");
                double fot;
                while (!double.TryParse(Console.ReadLine(), out fot))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double met = fot * 3.2808;
                double cent = fot / 0.032808;
                double tum = fot / 12d;
                double yards = fot * 0.33333;
                print = string.Format("{0} fot are {1:0.00} meter.{2:0.00} centeimeter. {3:0.00} tum .{4:0.00} yards", fot, met, cent, tum, yards);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine(); 
            }
            
            else if (Cho == 4)
            {
                Console.WriteLine("Input to convert tum! ");
                double tum;
                while (!double.TryParse(Console.ReadLine(), out tum))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double met = tum / 39.37;
                double cent = tum / 0.3937;
                double fot = tum * 0.08333;
                double yards = tum * 0.027778;
                print = string.Format("{0} tum are {1:0.00} meter.{2:0.00} centimeter . {3:0.00} fot .{4:0.00} yards .", tum, met, cent, fot, yards);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
            }
           
            else if (Cho == 5 )
            {
                Console.WriteLine("Input to convert yard! ");
                double yard;
                while (!double.TryParse(Console.ReadLine(), out yard))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double met = yard / 1.0936;
                double cent = yard / 0.010936;
                double fot = yard * 3;
                double tum = yard * 36d;
                print = string.Format("{0} yard are {1:0.00} meter . {2:0.00}  centimeter .{3:0.00} fot .{4:0.00} tum .", yard, met, cent, fot, tum);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine(); 
            } 
        }
    }
}

                
                

            
        



