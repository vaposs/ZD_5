using System;

namespace ZD_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ConstrainToRange(5,6,2));
        }

        public static int ConstrainToRange(int value, int min, int max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            else
                return value;
        }
    }
}
