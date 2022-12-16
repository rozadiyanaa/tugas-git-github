using System;

namespace UTS
{
    class soallima
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3,3];
            char player = 'X';
            bool gameOver = false;
            
            //memanggil inisialisasi
            Initializations(board);

            while(gameOver == false)
            {
                Console.Clear();
                printBoard(board);

                Console.Write("Input Row(0-2) = ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Input Coloumn(0-2) = ");
                int coloumn = int.Parse(Console.ReadLine());
                
                
            }
        }
    }
}
