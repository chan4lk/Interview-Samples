using System;
using System.Threading;
using NUnit.Framework;

namespace Interview
{
    class TicTacTest
    {
        int player = 0;
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int flag;
        int choice;       

        public void Play()
        {            
            do
            {
                if(player % 2 == 0)
                {
                    Console.WriteLine("Player 1 chance");
                }
                else
                {
                    Console.WriteLine("Player 2 chance");
                }
                Board();
                Console.WriteLine("Please Enter the choice");
                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Please try again already filled");
                    Thread.Sleep(2000);
                }

                flag = CheckWin();

               
            } while (flag != 1 && flag != -1);

            Console.WriteLine("Player {0} has won ", player % 2 + 1);
            Board();
            Console.ReadLine();
        }

        private void Board()
        {
            Console.WriteLine("  |  |  ");
            Console.WriteLine(" {0}  | {1} | {2}  ", arr[1], arr[2], arr[3]);
            Console.WriteLine("  |  |  ");
            Console.WriteLine(" {0}  | {1} | {2}  ", arr[4], arr[5], arr[6]);
            Console.WriteLine("  |  |  ");
            Console.WriteLine(" {0}  | {1} | {2}  ", arr[7], arr[8], arr[9]);
        }

        private int CheckWin()
        {
            #region Horizontal win conditions
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            #endregion

            #region  Vertical win conditions
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal win conditions
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Draw conditions
            else if (   arr[1] != '1' && arr[2] != '2' && arr[3] != '3'
                     && arr[4] != '4' && arr[5] != '5' && arr[6] != '6'
                     && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

        [Test]
        public void TicTact()
        {
            Play();
        }

        static void Main(string[] args)
        {
            TicTacTest test = new TicTacTest();
            test.Play();
        }
    }
}
