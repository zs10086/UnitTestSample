using System;

namespace ClassLibrary1
{
    public class Math
    {
        public static bool IsOdd(int n)
        {
            if (n % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
