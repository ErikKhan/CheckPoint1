using System;
using System.Linq;


namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Product name AND Type 'EXIT' to quit the program");
            int index = 0;
            string[] productName = new string[20];
            //Using While Loop to get the input from user
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a Product Name:  ");
                string product = Console.ReadLine().ToUpper();
                if (product.ToLower().Trim() == "exit")
                
                {
                    Array.Sort(productName);
                    //Using ForEach Loop to get the value of each product
                    foreach (string name in productName)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
                if (product.Contains("-"))
                {
                    string[] split = product.Split('-');

                    bool isTherenumber = split[0].Any(char.IsDigit);
                    int great;
                    bool isInt = int.TryParse(split[1], out great);

                    
                    if (split.Length > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cannot add more than two fields !!");

                    }
                    else if (split[0] == String.Empty )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This is for only letter field !!");
                    }
                    else if (!isInt)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("After split Right side should not have a letter !!");
                    }
                    else if ((great < 200 || great > 500))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number must be between 200 and 500 !!");
                    }
                    else if (isTherenumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("After split Left side should not have a number !!");
                    }
                    else
                    {

                        Array.Resize(ref productName, index + 1);
                        productName[index] = product;
                        index++;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Product number must have '-' !!");
                }
               
                
            }
            
            
           
            

            Console.ReadLine();
        }
    }
}
