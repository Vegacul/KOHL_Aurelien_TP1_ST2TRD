using System;

namespace TP1
{
	public class Exercice1
	{
		public void main()
		{

			Console.WriteLine("\nchoose question 1,2 or 3");
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


		private static void Part1()
		{
			Console.WriteLine("\nMultiplication Tables :");

			for (int i = 2; i <= 12; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					Console.WriteLine("{0}*{1}={2}", i, j, i * j);
				}
				Console.WriteLine("\n");
			}

		}

		private static void Part2()
        {
			Console.WriteLine("\nMultiplication Tables odd :");

			for (int i = 2; i <= 12; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					int k = i * j;

					if (IsOdd(k))
					{
						Console.WriteLine("{0}*{1}={2}", i, j, k);
					}

				}
				Console.WriteLine("\n");
			}

		}

		private static void Part3()
		{
			Console.WriteLine("\nCustome Multiplication Tables : \n");
			var value = AskUserForParameter();
			Console.WriteLine("You have choice " + value + "\n");


			for (int j = 1; j <= 10; j++)
			{
				Console.WriteLine("{0}*{1}={2}", value, j, value * j);
			}
			Console.WriteLine("\n");


		}



		private static int AskUserForParameter()
		{
			Console.WriteLine("\nPlease write a number and press enter :");
			int.TryParse(Console.ReadLine(), out var result);
			return result;
		}

		public static bool IsOdd(int value)
		{
			return value % 2 != 0;
		}
	}
}
