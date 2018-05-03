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
        public static ArrayList Names = new ArrayList();
        public static ArrayList Numbers = new ArrayList();
        public static ArrayList Hometown = new ArrayList();
        public static ArrayList Food = new ArrayList();
        public static void ArrayBuilder()
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
        }

        static void Main(string[] args)
        {
            
            ArrayBuilder();
            Console.WriteLine("would you like to know more about a student or enter information?");
            Console.WriteLine("Enter: M for More or E for Enter");
            string input = Console.ReadLine().ToUpper();

            if (input == "M")
            {
                string input5;
                do
                {
                    Console.WriteLine("which student would you like to know about (1-5)?");
                    string input2 = (Console.ReadLine());

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
                    Console.WriteLine();
                    Console.WriteLine("Would you like information about another student? (Y/N): ");
                    input5 = Console.ReadLine().ToUpper();
                } while (input5 == "Y");
            }
            else
            {
                string input4;
                do
                { Console.Write("Please enter a name: ");
                    string input3 = (Console.ReadLine());
                    //takes user input and adds to arraylist
                    Names.Add(input3);

                    Console.WriteLine("Would you like to enter another name? (Y/N)");
                    input4 = Console.ReadLine().ToUpper();
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
