using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            string userResponse = ""; 
            Console.WriteLine("Menu: Which ice cream would you like to order");
            Console.WriteLine("M) Mint");
            Console.WriteLine("B) Banana");
            Console.WriteLine("S) Strawberry");
            Console.WriteLine("C) Chocolate");
            int Mint = 10; 
            int Banana = 10; 
            int Strawberry = 10;
            int Chocolate = 10; 
            userResponse = Console.ReadLine(); 

            switch (userResponse)
            {
                case "M":
                Console.WriteLine("You've ordered Mint ice cream");
                Mint--; 
                break;

                case "B":
                Console.WriteLine("You've ordered Banana ice cream");
                Banana--;
                break;

                case "S":
                Console.WriteLine("You've ordered Strawberry ice cream");
                Strawberry--;
                break;

                case "C":
                Console.WriteLine("You've ordered Chocolate ice cream");
                Chocolate--;                
                break;

                default:
                Console.WriteLine("Please enter a valid response");

            }
            while (true);
            Console.ReadLine();
            }   
        }
    }
            
            