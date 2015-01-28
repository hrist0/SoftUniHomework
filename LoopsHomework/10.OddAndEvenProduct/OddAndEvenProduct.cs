using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        string numbers = Console.ReadLine();
        string[] newNumb = numbers.Split(' ');
        int newNew = 0;
        int odd = 1;
        int even = 1;
        for (int i = 0; i < newNumb.Length; i++)
        {
            newNew = Convert.ToInt32(newNumb[i]);
            if (i % 2 == 0)
            {
                odd *= newNew;
            }
            else
            {
                even *= newNew;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("yes \nproduct = {0}", even);
        }
        else
        {
            Console.WriteLine("no \nodd_product = {0}\neven product = {1}", odd, even);
        }
    }
}