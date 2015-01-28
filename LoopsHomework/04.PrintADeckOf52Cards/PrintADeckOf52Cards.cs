using System;

    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int x = 0; x <= 3; x++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write("2");
                            if (x == 0)                           
                                Console.Write("♣ ");                           
                            if (x == 1)
                                Console.Write("♦ ");                         
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 3:
                            Console.Write("3");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 4:
                            Console.Write("4");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 5:
                            Console.Write("5");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 6:
                            Console.Write("6");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 7:
                            Console.Write("7");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 8:
                            Console.Write("8");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 9:
                            Console.Write("9");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 10:
                            Console.Write("10");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 11:
                            Console.Write("J");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 12:
                            Console.Write("Q");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 13:
                            Console.Write("K");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                        case 14:
                            Console.Write("A");
                            if (x == 0)
                                Console.Write("♣ ");
                            if (x == 1)
                                Console.Write("♦ ");
                            if (x == 2)
                                Console.Write("♥ ");
                            if (x == 3)
                                Console.Write("♠");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

