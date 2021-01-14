using System;
namespace project
{
    public class Degri
    {
        public int Choice;
            History history = new History();
        public void GetDeg()
        {
            Console.Clear();
            bool menuDegri = true;
            Choice = 0;
            while (menuDegri)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("********************************");
                Console.WriteLine(" Choose from these options: ");
                Console.WriteLine("1) CelsiusToFahrenheit ");
                Console.WriteLine("2) CelsiusToKelvin ");
                Console.WriteLine("3) FarenheitToCelsius ");
                Console.WriteLine("4) FarenheitToKelvin ");
                Console.WriteLine("5) KelvinToCelsius");
                Console.WriteLine("6) KelvinToFahrenheit");
                Console.WriteLine("7) Back to main menu");
                Console.WriteLine("********************************");
                Console.WriteLine();

                while (!int.TryParse(Console.ReadLine(), out Choice) || Choice > 7 || Choice < 1)
                {
                    Console.WriteLine("Invaild number, try again");
                }
                switch (Choice)
                {
                    case 1:
                        CelsiusToFahrenheit();
                        break;
                    case 2:
                        CelsiusToKelvin();
                        break;
                    case 3:
                        FarenheitToCelsius();
                        break;
                    case 4:
                        FarenheitToKelvin();
                        break;
                    case 5:
                        KelvinToCelsius();
                        break;
                    case 6:
                        KelvinToFahrenheit();
                        break;
                    case 7:
                        menuDegri = false;

                        break;
                   
                }

            }
        }
        public void CelsiusToFahrenheit()
        {
            Console.Write("Enter the amount of celsius: ");
            double celsius;
            while(!double.TryParse(Console.ReadLine(),out celsius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double fahrenheit = celsius * 18 / 10 + 32;
                string print = string.Format("Fahrenheit = {0:0.00}", fahrenheit );
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
           
          
        }
        public void CelsiusToKelvin()
        {
            Console.Write("Enter the amount of celsius : ");
            double celsius;
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Kelvin = celsius + 273;
                string print = string.Format("Kelvin = {0:0.00}", Kelvin );
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
         
        }
        public void FarenheitToCelsius()
        {
            Console.Write("Enter the amount of farenhit : ");
            double farenhit;
            while (!double.TryParse(Console.ReadLine(), out farenhit))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double celsius=(farenhit - 32)/1.80;
                string print = string.Format(" celsius= {0:0.00}", celsius);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
         
            
        }

        public void FarenheitToKelvin()
        {
            Console.Write("Enter the amount of farenhit: ");
            double farenhit;
            while (!double.TryParse(Console.ReadLine(), out farenhit))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Kelvin = ((farenhit - 32) / 1.80) + 273.15;
                string print = string.Format("Kelvin = {0:0.00}", Kelvin);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
           

        }
        public void KelvinToCelsius()
        {
            Console.Write("Enter the amount of  Kelvin: ");
            double kelvin;
           
            while (!double.TryParse(Console.ReadLine(), out kelvin ))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double celsius = kelvin-273.15;
                string print = string.Format("celsius = {0:0.00}", celsius);
                history.AddToHistory(print);
                Console.WriteLine(print);
                Console.ReadLine();
          
        }
        public void KelvinToFahrenheit()
        {
            Console.Write("Enter the amount of  Kelvin: ");
                double kelvin;

                while (!double.TryParse(Console.ReadLine(), out kelvin))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double farenhit = ((kelvin - 273.15)*1.80)+32 ;
                    string print = string.Format(" farenhit= {0:0.00}", farenhit);
                    history.AddToHistory(print);
                    Console.WriteLine(print);
                    Console.ReadLine();
            
        }

     }
}
        
    
