using System;

namespace ClassLibrary1
{
    /// <summary>
    /// 数学类
    /// </summary>
    public class Math
    {
        /// <summary>
        /// 奇数判断
        /// </summary>
        /// <param name="n">待判断数字</param>
        /// <returns></returns>
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
