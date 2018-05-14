using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9StudentIndexAlphabetical
{
    class Program
    {
        public static List<string> Names = new List<string>();
        public static List<string> Numbers = new List<string>();
        public static List<string> Hometown = new List<string>();
        public static List<string> Food = new List<string>();
        public static List<string> Color = new List<string>();
        public static void ListBuilder()
        {
            Names.Add("Abby");
            Names.Add("Bobby");
            Names.Add("Cindy");
            Names.Add("Darielle");
            Names.Add("Eddie");
            Numbers.Add("1");
            Numbers.Add("2");
            Numbers.Add("3");
            Numbers.Add("4");
            Numbers.Add("5");
            Hometown.Add("Atlantic City");
            Hometown.Add("Boston");
            Hometown.Add("Detroit");
            Hometown.Add("Jackson");
            Hometown.Add("Los Angeles");
            Food.Add("Apples");
            Food.Add("Bananas");
            Food.Add("Carrots");
            Food.Add("Grapes");
            Food.Add("Pears");
            Color.Add("blue");
            Color.Add("red");
            Color.Add("yellow");
            Color.Add("green");
            Color.Add("gray");

        }

        static void Main(string[] args)
        {

            ListBuilder();
            Console.WriteLine("would you like to know more about a student or enter information?");
            Console.WriteLine("Enter: M for More or E for Enter");
            string input = Console.ReadLine().ToUpper();

            while (input == "M")
            {
                string input5;

                {
                    Console.WriteLine("which student would you like to know about (1-5)?");
                    string input2 = (Console.ReadLine());
                    //int id = 0;

                   /* while (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("your input was not valid, try again");
                        Console.ReadLine();
                        continue;
                    }*/
                        //shift users input so it's 0-4 and not 1-5
                        int index;
                        //int index2;
                        //int index3;
                        int.TryParse(input2, out index);
                        //int.TryParse(Hometown, out index2);
                        //int.TryParse(Food, out index3);
                        index--;
                        Console.WriteLine("Name: " + (Names[index]));
                        Console.WriteLine("Hometown: " + (Hometown[index]));
                        Console.WriteLine("Favorite Food: " + (Food[index]));
                        Console.WriteLine("Favorite Color: " + (Color[index]));
                        Console.WriteLine();
                        Console.WriteLine("Would you like information about another student? (Y/N): ");
                        input5 = Console.ReadLine().ToUpper();

                        if (input5 != "Y")
                            
                    {
                        break;
                    }
                }
            }
            while (input == "E")
            {
                string input4;
                do
                { Console.Write("Please enter a name: ");
                    string input3 = (Console.ReadLine());
                    //takes user input and adds to arraylist
                    Names.Add(input3);

                    Console.WriteLine("Would you like to enter another name? (Y/N)");
                    input4 = Console.ReadLine().ToUpper();
                if (input4 != "Y")
                    {
                        for (int i = 0; i < Names.Count; i++)
                        {
                            Names.Sort(); Console.WriteLine(Names[i]);
                        }
                        Console.WriteLine("have a great day!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                
                } while (input4 == "Y");
                { for (int i = 0; i < Names.Count; i++)
                    {
                        Names.Sort(); Console.WriteLine(Names[i]);
                    }
                }
            }
        }
               

        }
    
}
