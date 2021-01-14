using System;
namespace project
{
    public class OhmsLag
    {
            History history = new History();
        public void Getcho()
        {
            Console.Clear();
            Console.WriteLine("Choose to convert between");
            Console.WriteLine("1) Voltage");
            Console.WriteLine("2) Resistance");
            Console.WriteLine("3) Current");
            int choi;

            while (!int.TryParse(Console.ReadLine(), out choi) || choi > 3|| choi < 1)
            {
                Console.WriteLine("Invalid number, try again.");
            }
            Console.WriteLine();

            if (choi == 3)
            {
                Console.WriteLine("Please enter the voltage:");
                double voltage;
                while (!double.TryParse(Console.ReadLine(), out voltage))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
              
                Console.WriteLine("Please enter the resistance:");
                double resistance;
                while (!double.TryParse(Console.ReadLine(), out resistance))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                
                double current = voltage / resistance;
            
                string print = string.Format("Current are {0:0.00} ampere:", current);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
                
            }

            else if (choi == 1)
            {
                Console.WriteLine("Please enter the current:");
                double current;
                while (!double.TryParse(Console.ReadLine(), out current))
                {
                    Console.WriteLine("Invalid number, try again");
                }
                
                Console.WriteLine("Please enter the resistance:");
                double resistance;
                while (!double.TryParse(Console.ReadLine(), out resistance))
                {
                    Console.WriteLine("Invalid number, try again");
                }
                
                double voltage = current * resistance;
                string print = string.Format("Voltage are: {0:0.00} volt", voltage);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
                
            }

            else if (choi == 2)
            {
                Console.WriteLine("Please enter the current:");
                double current;
                while (!double.TryParse(Console.ReadLine(), out current))
                {
                    Console.WriteLine("Invalid number, try again");
                }
                
                Console.WriteLine("Please enter the voltage:");
                double voltage;
                while (!double.TryParse(Console.ReadLine(), out voltage))
                {
                    Console.WriteLine("Invalid number, try again");
                }
        
                double restitance = voltage / current;
                string print = string.Format("Restitance are: {0:0.00} ohm", restitance);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
                
                
            }
           
        }

    }
}

        
    
