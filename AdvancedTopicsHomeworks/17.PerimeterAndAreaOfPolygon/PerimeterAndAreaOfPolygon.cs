using System;

class PerimeterAndAreaOfPolygon
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string coor = "";
        for (int i = 0; i < input; i++)
        {
            coor += Console.ReadLine() + " ";
        }
        string[] split = coor.Split(' ');
        int count = 0;
        int startXtwo = 0;
        int countXtwo = 0;
        int countX = 0;
        int countY = 1;
        int startX = 0;
        int startY = 1;
        double area = 0;
        int[,] cor = new int[input, 2];
        for (int i = 0; i < input; i++)
        {
            for (int a = 0; a < 2; a++)
            {
                cor[i, a] = Convert.ToInt32(split[count]);
                count++;
            }
        }
        for (int i = 0; i < count; i++)
        {
            int firstResult = cor[startX, countX] * cor[startXtwo, countXtwo];
            int secondResult = cor[startY, countY] * cor[star
            area = cor[startX, countX] * cor[startXtwo, countXtwo] - cor[] * cor[countTwo] ;
        }
    }
}

//split[startX + count] * split[count] - split[startY] * split[countTwo] 

