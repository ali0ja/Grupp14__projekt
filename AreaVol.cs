using System;
namespace project
{
    public class AreaVol
    {

        public int Choice;
        History history = new History();
        public void GetChar()

        {
            Console.Clear();

            bool menuAreaVol = true;
            Choice = 0;
            while (menuAreaVol)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("********************************");
                Console.WriteLine("Choose from these options: ");
                Console.WriteLine("1) Circle area");
                Console.WriteLine("2) Rectangle area");
                Console.WriteLine("3) Sphere Volym");
                Console.WriteLine("4) Traingle area");
                Console.WriteLine("5) Sphere area");
                Console.WriteLine("6) Cube volume");
                Console.WriteLine("7) Pyramid volume");
                Console.WriteLine("8) Back to main menu");
                Console.WriteLine("********************************");
                Console.WriteLine();

                while (!int.TryParse(Console.ReadLine(), out Choice) || Choice > 8 || Choice < 1)
                {
                    Console.WriteLine("Invaild number, try again");
                }
                switch (Choice)
                {
                    case 1:
                        CirArea();
                        break;
                    case 2:
                        RecArea();
                        break;
                    case 3:
                        SphereVolym();
                        break;
                    case 4:
                        TriArea();
                        break;
                    case 5:
                        SphereArea();
                        break;
                    case 6:
                        KubVolyme();
                        break;
                    case 7:
                        PyramidVolym();
                        break;
                    case 8:
                        menuAreaVol = false;
                        break;
                }
            }
        }

        public void CirArea()
        {
            double pi = 3.14;
            Console.WriteLine("Please enter the radius of the circle :");

            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double cirarea = pi * Math.Sqrt(radius);
            string print = string.Format("The area of the circle is : {0:0.00}", cirarea);
            history.AddToHistory(print);
            Console.WriteLine(print);
        }
        public void RecArea()
        {

            Console.WriteLine("Please enter the length of the rectangle: ");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the width of the rectangle: ");
            double width;
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double recarea = length * width;
            string print = string.Format("The area of the rectangle is : {0:0.00}", recarea);
            history.AddToHistory(print);
            Console.WriteLine(print);

        }
        public void SphereVolym()
        {
            double pi = 3.14;
            Console.WriteLine("Please enter the radius of the Sphere:");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Spherevolym = 4 * pi * (radius * radius * radius / 3);
            string print = string.Format(" SphereVolym are {0:0.00}:", Spherevolym);
            history.AddToHistory(print);
            Console.WriteLine(print);

        }
        public void TriArea()
        {
            Console.Write("Enter the Value of basen : ");
            double bas;
            while (!double.TryParse(Console.ReadLine(), out bas))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.Write("Enter the Value of height : ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Traingle = (height * bas) / 2;
            string print = string.Format("\n\nThe Area of Triangle is: {0:0.00}", Traingle);
            history.AddToHistory(print);
            Console.WriteLine(print);

        }
        public void KubVolyme()
        {
            Console.WriteLine("Please enter the width of the kub :");
            double width;
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the height of the kub:");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the length of the kub:");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double kubvolym = length * width * height;
            string print = string.Format("kubvolym are : {0:0.00}", kubvolym);
            history.AddToHistory(print);
            Console.WriteLine(print);
        }
        public void PyramidVolym()
        {
            Console.WriteLine("Please enter the width of the pyramid :");
            double width;
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the height of the  pyramid:");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the length of the pyramid:");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double slant1 = Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(height, 2));
            double slant2 = Math.Sqrt(Math.Pow(length / 2, 2) + Math.Pow(height, 2));
            double pyrvol = (length * width) + (length * slant1) + (width * slant2);
            string print = string.Format(" PyramidArea are: {0:0.00}", pyrvol);
            history.AddToHistory(print);
            Console.WriteLine(print);
        }
        public void SphereArea()
        {
            double pi = 3.14;
            Console.WriteLine("Please enter the radius of the Sphere:");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Spherearea = 4 * pi * Math.Sqrt(radius);
            string print = string.Format(" Spherearea are {0:0.00}:", Spherearea);
            history.AddToHistory(print);
            Console.WriteLine(print);

        }
    }
}


