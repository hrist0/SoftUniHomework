using System;

    class CountingAWordInAText
    {
        static void Main(string[] args)
        {
            int bufSize = 1024;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));
            
            string input = Console.ReadLine().ToUpper();
            string text = Console.ReadLine().ToUpper();
            int count = 0;
            string[] newText = text.Split('.', '"', '”', '"', '+', '!', '?', ':', '/', ',', '\'', '@','(', ')','\\', ' ');
            for (int i = 0; i < newText.Length; i++)
            {
                if (input == newText[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

