using System;

namespace ConsoleAppTest
{
    class Program
    {

        static void Main(string[] args)
        {
            int lucky = 0;
            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                    for (int c = 0; c <= 9; c++)
                        for (int d = 0; d <= 9; d++)
                            for (int e = 0; e <= 9; e++)
                            {
                                int f = (a + b + c) - (d + e);
                                if (f <= 9 && f >= 0)
                                    lucky++;
                            }
            Console.WriteLine(lucky);
        }
    }
}
