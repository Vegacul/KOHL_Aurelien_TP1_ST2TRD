using System;

namespace TP1
{
	public class Exercice3
	{
		public void main()
		{
            Console.WriteLine("n for every value between - 3 and 3" );
            
            Try_Catch(-3,3 );

        }

        public static void Try_Catch(int born1, int number)
        {

            int PowerFunction(int x)
            {
                return (int)(Math.Pow(x, 2) - 4);
            }
            for (int i = born1; i <= number; i++)
                try
                {
                    int oui = 10 / PowerFunction(i);
                    Console.WriteLine(oui);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("a DividedByZero Exception for x equal to " + i);

                }

        }
    }
}