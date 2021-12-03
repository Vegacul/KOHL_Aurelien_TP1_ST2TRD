using System;

namespace TP1
{
	public class Exercice4
	{
		public void main()
		{
			Square();
		}

		public static void Square()
		{
			int n = 0;
			int m = 0;
			Console.WriteLine("Please choose the n and m off your square :) ");
			while (((1 <= n && n <= 1000) && (1 <= m && m <= 1000)) == false)
			{
				n = AskUserForParameter();
				m = AskUserForParameter();
			}

			for (int i = 0; i <= n - 1; i++)
			{
				if ((i == n - 1) || (i == 0))
				{
					line(0, m);
				}
				else
				{
					line(1, m);
				}
			}
			if ((n == 1) && (m == 1))
			{
				Console.WriteLine("0");
			}

            void line(int a, int M)
            {
                string result = null;
                if (a == 0) 
                {
                    string v = null;
                    for (int i = 0; i <= m - 3; i++)
                    {
                        v = v + "-";
                    }

                    if (M == 1)
                    {
						Console.WriteLine("0");
                    }
                    else
                    {
                        result = "0" + v + "0";
                        Console.WriteLine(result);
                    }
                }
                else 
                {

                    if (M == 1)
                    {
                        result = "|";
						Console.WriteLine(result);
					}

                    for (int i = 0; i <= M - 3; i++)
                    {
						result += " ";
                    }

                    if (M >= 2)
                    {
                        Console.WriteLine("|" + result + "|");
                    }


                }
            }

            static int AskUserForParameter()
			{
				Console.WriteLine("Please write a number and press enter :");
				int.TryParse(Console.ReadLine(), out var result);
				return result;
			}

		}
	}
}