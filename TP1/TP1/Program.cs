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
            } while (choice != 6);
            Console.ReadLine();
        }

        public static string getMainMenu()
        {

            return " ************ Menu ************\n "
                    + " 1: Exercise Multiplication Tables\n "
                    + " 2: Exercise More math\n "
                    + " 3: Exercise Try/Catch\n "
                    + " 4: Exercise Square\n "
                    + " 5: Exercise Christmas Tree\n "
                    + " 6 : Go away from this evil \n "
                    + "  Whats is your choice ? :\n ";
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
                    result += "\nBad choice, try again";
                    break;
            }
            return result;
        }


    }
}
