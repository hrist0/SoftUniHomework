using System;

    class MatrixOFPalindromes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int rows = Convert.ToInt32(inputs[0]);
            int cols = Convert.ToInt32(inputs[1]);
            char pal = 'a';
            for (int i = 0; i < rows; i++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.Write((char)(pal + i) + "" + (char)(pal + x + i) + "" + (char)(pal + i) + " ");
                }
                Console.WriteLine();
            }
        }
    }

