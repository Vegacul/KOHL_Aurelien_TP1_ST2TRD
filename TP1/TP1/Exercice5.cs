using System;

namespace TP1
{
	public class Exercice5
	{
        public void main()
        {
            Console.WriteLine("choose 1 for a tree or 2 for a special tree ");
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
                Console.WriteLine("relou toi");
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


                if (a != 0) return;
                {
                    for (int i = 0; i <= high * 2; i++) // largeur max de l'arbre
                    {
                        if ((i >= left) && (i <= right)) // vérifier si dans l'interval où on met des *
                        {
                            if (current_line % 3 == i % 3)
                            {
                                if (current_line % 9 == i % 9)
                                {
                                    result = result + "o";
                                }
                                else
                                {
                                    result = result + "i";
                                }
                            }
                            else
                            {
                                result = result + "*";
                            }
                        }
                        else // sinon mettre un espace
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
            Console.WriteLine("choose a tree Size, must be between 3 and 20:");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }


    }
}