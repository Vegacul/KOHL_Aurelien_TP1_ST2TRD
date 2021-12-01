using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1
{
    class Program
    {

        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.Write(getMainMenu());
                choice = Convert.ToInt32(Console.ReadLine());
                string result = computeMainMenuChoice(choice);
                Console.WriteLine(result);
            } while (choice != 5);
            Console.ReadLine();
        }

        public static string getMainMenu()
        {

            return " ****** Menu ******\n "
                    + " Exercise 1: Multiplication Tables\n "
                    + " Exercise 2: More math\n "
                    + " Exercise 3: Try/Catch\n "
                    + " Exercise 4: Square\n "
                    + " Exercise 5: Christmas Tree\n "
                    + " Whats is your choice ? :\n ";
        }

        public static string computeMainMenuChoice(int choice)
        {
            string result = " ";

            switch (choice)
            {
                case 1:
                    var ex1 = new Exercice1();
                    ex1.main();
                    break;
                case 2:
                    var ex2 = new Exercice2();
                    ex2.main();
                    break;
                case 3:
                    var ex3 = new Exercice3();
                    ex3.main();
                    break;
                case 4:
                    var ex4 = new Exercice4();
                    ex4.main();
                    break;
                case 5:
                    var ex5 = new Exercice5();
                    ex5.main();
                    break;
                default:
                    result += "Bad choice, try again";
                    break;
            }
            return result;
        }


    }
}
