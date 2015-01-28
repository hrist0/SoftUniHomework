using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class RemoveNames
    {
        static void Main(string[] args)
        {
            string fNames = Console.ReadLine();
            string sNames = Console.ReadLine();
            string[] fNew = fNames.Split(' ');
            string[] sNew = sNames.Split(' ');
            List<string> names = new List<string>();
            for (int i = 0; i < fNew.Length; i++)
            {
                names.Add(fNew[i]);              
            }
            for (int i = 0; i < sNew.Length; i++)
            {
                string all = sNew[i];
                for (int x = 0; x < sNew.Length; x++)
                {
                    names.Remove(all);
                }
            }
            foreach (string item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

