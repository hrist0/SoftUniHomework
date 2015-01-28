using System;
using System.Linq;
using System.Collections.Generic;

class MagicCarNumbers
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int one = 0;
        int two = 0;
        List<string> letters = new List<string>();
        string result = "";
        int count = 0;
        for (int i = 0; i <= 9; i++)
        {
            for (int x = 0; x <= 9; x++)
            {
                for (int y = 0; y < 11; y++)
                {
                    switch (y)
                    {
                        case 0:
                            one = 10;
                            break;
                        case 1:
                            one = 20;
                            break;
                        case 3:
                            one = 30;
                            break;
                        case 4:
                            one = 50;
                            break;
                        case 5:
                            one = 80;
                            break;
                        case 6:
                            one = 110;
                            break;
                        case 7:
                            one = 130;
                            break;
                        case 8:
                            one = 160;
                            break;
                        case 9:
                            one = 200;
                            break;
                        case 10:
                            one = 240;
                            break;
                    }
                    for (int z = 0; z < 11; z++)
                    {
                        switch (z)
                        {
                            case 0:
                                two = 10;
                                break;
                            case 1:
                                two = 20;
                                break;
                            case 3:
                                two = 30;
                                break;
                            case 4:
                                two = 50;
                                break;
                            case 5:
                                two = 80;
                                break;
                            case 6:
                                two = 110;
                                break;
                            case 7:
                                two = 130;
                                break;
                            case 8:
                                two = 160;
                                break;
                            case 9:
                                two = 200;
                                break;
                            case 10:
                                two = 240;
                                break;
                        }
                        if (40 + i + i + i + i + one + two == input && !letters.Contains("CA" + (char)i + (char)i + (char)i + (char)i + (char)one + (char)two))
                        {
                            result = "CA" + (char)i + (char)i + (char)i + (char)i + (char)one + (char)two;
                            letters.Add(result);
                            count++;
                        }
                        if (40 + i + x + x + x + one + two == input && !letters.Contains("CA" + (char)i + (char)x + (char)x + (char)x + (char)one + (char)two))
                        {
                            result = "CA" + (char)i + (char)x + (char)x + (char)x + (char)one + (char)two;
                            letters.Add(result);
                            count++;
                        }
                        if (40 + i + i + x + x + one + two == input && !letters.Contains("CA" + (char)i + (char)i + (char)x + (char)x + (char)one + (char)two))
                        {
                            result = "CA" + (char)i + (char)i + (char)x + (char)x + (char)one + (char)two;
                            letters.Add(result);
                            count++;
                        }
                        if (40 + i + x + i + x + one + two == input && !letters.Contains("CA" + (char)i + (char)x + (char)i + (char)x + (char)one + (char)two))
                        {
                            result = "CA" + (char)i + (char)x + (char)i + (char)x + (char)one + (char)two;
                            letters.Add(result);
                            count++;
                        }
                        if (40 + i + x + x + i + one + two == input && !letters.Contains("CA" + (char)i + (char)x + (char)x + (char)i + (char)one + (char)two))
                        {
                            result = "CA" + (char)i + (char)x + (char)x + (char)i + (char)one + (char)two;
                            letters.Add(result);
                            count++;
                        }
                        if (40 + i + i + i + x + one + two == input && !letters.Contains("CA" + (char)i + (char)i + (char)i + (char)x + (char)one + (char)two))
                        {
                            result = "CA" + (char)i + (char)i + (char)i + (char)x + (char)one + (char)two;
                            letters.Add(result);
                            count++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }   
}

