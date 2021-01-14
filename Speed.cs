using System;
namespace project
{
    public class Speed
    {
        public double speed;
            
            History history = new History();
            string print;
        public void Getspeed(){
             Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            
            Console.WriteLine("Input the distance you want to calculate(km):");
            double distance;
            
             while (!double.TryParse(Console.ReadLine(), out distance))
                {
                 Console.WriteLine("Invalid number,try again ");
                }
                Console.WriteLine("Input time (min) : ");
                 double time;
             while (!double.TryParse(Console.ReadLine(), out time))
                {
                 Console.WriteLine("Invalid number,try again ");
                }
                double speed= distance /time;
                string print = string.Format("Speed are {0:0.00} (km/min)." ,speed);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
               
                
        }
    }
}