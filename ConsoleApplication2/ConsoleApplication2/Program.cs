using System;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            char row = 'X';
            char col = 'X';
            for(int i = 0; i < 8; i++)
            {
                if (row == 'X' && i>0) col = 'O';
                if (row == 'O') col = 'X';
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(col);
                    if (col == 'O') col = 'X';
                   else if (col == 'X') col = 'O';

                }
                row = col;
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
