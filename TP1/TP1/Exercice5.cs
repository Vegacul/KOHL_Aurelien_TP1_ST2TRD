using System;

namespace TP1
{
	public class Exercice5
	{
        public void main()
        {
            Console.WriteLine("\nchoose 1 for a tree or 2 for a special tree ");
            int.TryParse(Console.ReadLine(), out var result);
            if (result == 1)
            {
                SapinClassique();
            }
            else if((result == 2))
            {
                SapinPimp();
            }
            else
            {
                Console.WriteLine("\nrelou toi");
            }


        }


        private static void SapinClassique()
        {
            int high = 0;

            while ((3 < high && high <= 20) == false)
            {
                high = AskUserForParameter();
            }

            for (int ligne = 0; ligne <= high - 1 + 1; ligne++)
            {
                Branche(ligne == high ? 1 : 0, ligne);
            }

            void Branche(int a, int current_line)
            {
                string result = null;
                var middle = high + 1; 
                var right = middle + current_line;
                var left = middle - current_line;
                if (a == 1) 
                {

                    for (int i = 0; i <= high * 2; i++)
                    {
                        if ((i == middle - 1) )
                        {

                            result = result + "| |";
                        }
                        else
                        {
                            result = result + " ";
                        }
                    }
                    Console.WriteLine(result);
                }


                if (a != 0) return;
                {
                    for (int i = 0; i <= high * 2; i++) 
                    {
                        if ((i >= left) && (i <= right)) 
                        {
                            result = result + "*";
                        }
                        else 
                        {
                            result = result + " ";
                        }

                    }


                    Console.WriteLine(result);
                }
            }



        }

        private static void SapinPimp()
        {
            int high = 0;

            while ((3 < high && high <= 20) == false)
            {
                high = AskUserForParameter();
            }

            for (int ligne = 0; ligne <= high - 1 + 1; ligne++) 
            {
                Branche(ligne == high ? 1 : 0, ligne);
            }

            void Branche(int a, int current_line)
            {
                string result = null;
                var middle = high + 1; 
                var right = middle + current_line;
                var left = middle - current_line;
                if (a == 1) 
                {

                    for (int i = 0; i <= high * 2; i++)
                    {
                        if ((i == middle - 1))
                        {

                            result = result + "| |";
                        }
                        else
                        {
                            result = result + " ";
                        }
                    }
                    Console.WriteLine(result);
                }

                Random aleatoire = new Random();
                int compteuri = 0;
                int compteuro = 0;


                if (a != 0) return;
                {
                    for (int i = 0; i <= high * 2; i++) 
                    {
                        if ((i >= left) && (i <= right)) 
                        {
                            if (current_line % 3 == (i-2) % 3)
                            {
                                int nbRand = aleatoire.Next(10);
                                if ((nbRand%2 == 0) && (compteuri> compteuro*1.5) )
                                {
                                    result = result + "o";
                                    compteuro++;
                                }
                                else
                                {
                                    result = result + "i";
                                    compteuri++;
                                }
                            }
                            else
                            {
                                result = result + "*";
                            }
                        }
                        else 
                        {
                            result = result + " ";
                        }

                    }


                    Console.WriteLine(result);
                }
            }
        }

        static int AskUserForParameter()
        {
            Console.WriteLine("\nchoose a tree Size, must be between 3 and 20:");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }


    }
}