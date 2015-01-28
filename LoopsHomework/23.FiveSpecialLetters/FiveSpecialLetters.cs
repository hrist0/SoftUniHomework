using System;
using System.Collections.Generic;
using System.Linq;

class FiveSpecialLetters
{
    static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        char a = 'a';
        char b = 'b';
        char c = 'c';
        char d = 'd';
        char e = 'e';
        List<char> comb = new List<char>();
        List<int> much = new List<int>();
        int[] sum = new int[5];
        int result = 0;
        int aNum = 5;
        int bNum = -12; 
        int cNum = 47;
        int dNum = 7;
        int eNum = -32;
        int count = 0;
        for (int first = 0; first < 5; first++)
        {
            for (int second = 0; second < 5; second++)
            {
                for (int third = 0; third < 5; third++)
                {
                    for (int fourth = 0; fourth < 5; fourth++)
                    {
                        for (int fifth = 0; fifth < 5; fifth++)
                        {
                            switch (first)
                            {
                                case 0:
                                    sum[0] = aNum;
                                    break;
                                case 1:
                                    sum[0] = bNum;
                                    break;
                                case 2:
                                    sum[0] = cNum;
                                    break;
                                case 3:
                                    sum[0] = dNum;
                                    break;
                                case 4:
                                    sum[0] = eNum;
                                    break;
                            }
                            switch (second)
                            {
                                case 0:
                                    sum[1] = aNum;
                                    break;
                                case 1:
                                    sum[1] = bNum;
                                    break;
                                case 2:
                                    sum[1] = cNum;
                                    break;
                                case 3:
                                    sum[1] = dNum;
                                    break;
                                case 4:
                                    sum[1] = eNum;
                                    break;
                            }
                            switch (third)
                            {
                                case 0:
                                    sum[2] = aNum;
                                    break;
                                case 1:
                                    sum[2] = bNum;
                                    break;
                                case 2:
                                    sum[2] = cNum;
                                    break;
                                case 3:
                                    sum[2] = dNum;
                                    break;
                                case 4:
                                    sum[2] = eNum;
                                    break;
                            }
                            switch (fourth)
                            {
                                case 0:
                                    sum[3] = aNum;
                                    break;
                                case 1:
                                    sum[3] = bNum;
                                    break;
                                case 2:
                                    sum[3] = cNum;
                                    break;
                                case 3:
                                    sum[3] = dNum;
                                    break;
                                case 4:
                                    sum[3] = eNum;
                                    break;
                            }
                            switch (fifth)
                            {
                                case 0:
                                    sum[4] = aNum;
                                    break;
                                case 1:
                                    sum[4] = bNum;
                                    break;
                                case 2:
                                    sum[4] = cNum;
                                    break;
                                case 3:
                                    sum[4] = dNum;
                                    break;
                                case 4:
                                    sum[4] = eNum;
                                    break;
                            }
                            if (!much.Contains(sum[0]))
                            {
                                much.Add(sum[0]);
                                count++;
                            }
                            if (!much.Contains(sum[1]))
                            {
                                much.Add(sum[1]);
                                count++;
                            }
                            if (!much.Contains(sum[2]))
                            {
                                much.Add(sum[2]);
                                count++;
                            }
                            if (!much.Contains(sum[3]))
                            {
                                much.Add(sum[3]);
                                count++;
                            }
                            if (!much.Contains(sum[4]))
                            {
                                much.Add(sum[4]);
                                count++;
                            }
                            for (int i = 1; i <= count; i++)
                            {
                                result += i * much[i - 1];
                            }
                            if (result > min && result < max)
                            {
                                Console.WriteLine(result);
                            }
                            much.Clear();
                            count = 0;
                        }
                    }
                }
            }
        }
    }
}

