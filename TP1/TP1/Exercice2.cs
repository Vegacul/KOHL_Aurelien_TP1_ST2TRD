using System;

namespace TP1
{
	public class Exercice2
	{
		public void main()
		{
            Console.WriteLine("choose 1 for all prime number between 1 and 1000 ");
            Console.WriteLine("choose 2 for  Fibonacci  ");
            Console.WriteLine("choose 3 for  factorial function");
            int.TryParse(Console.ReadLine(), out var result);
            if (result == 1)
            {
                Part1();
            }
            else if ((result == 2))
            {
                Part2();
            }
            else if ((result == 3))
            {
                Part3();
            }
            else
            {
                Console.WriteLine("\nrelou toi");
            }
        }

        public void Part1()
        {
            Console.WriteLine("\nPrime number under 100: ");
            for (int I = 2; I < 100; I++) if (Prime(I)) Console.Write((int)I + " ");
            Console.WriteLine();

        }
        public void Part2()
        {
            var value = AskUserForParameter();
            
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < value; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public void Part3()
        {
            int num, n;
            num = AskUserForParameter();


            n = num;
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine("Factorial of {0}! = {1}\n", num, n);


        }


        private static int AskUserForParameter()
        {
            Console.WriteLine("\nPlease write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static int PrimeFactor(int N)
        {
            int Count = 2, I;
            double Racine = Math.Sqrt(N);
            for (I = 2; I <= Racine; I++) if (N % I == 0) Count++;
            return Count;
        }

        public static bool Prime(int N)
        {
            return (PrimeFactor(N) == 2);
        }

    }
}