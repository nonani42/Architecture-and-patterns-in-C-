
namespace Architecture_and_patterns_in_CSharp
{
    public class MathOperations
    {
        /// <summary>
        /// Returns factorial of the given number. If number is less than zero - returns -1;
        /// </summary>
        /// <param name="num"></param>
        /// <returns>factorial</returns>
        public static int GetFactorial(int num)
        {
            int factorial = 1;

            if (num < 0)
            {
                factorial = -1;
            }

            if (num > 1)
            {
                for (int i = num; i > 0; i--)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }

        public static int GetMaxEvenNum(int num)
        {
            int maxEvenNum = num;
            do
            {
                maxEvenNum--;
            } while (!(maxEvenNum % 2 == 0));
            return maxEvenNum;
        }

        /// <summary>
        /// Returns summ from 1 to given number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetSum(int num)
        {
            int sum = 0;
            for (int i = num; i > 0; i--)
            {
                sum += i;
            }
            return sum;
        }
    }
}
