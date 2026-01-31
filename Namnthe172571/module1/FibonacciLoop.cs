using Namnthe172571.module1;

namespace Namnthe172571.module1
{
    public class FibonacciLoop : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (flag) return -1;
            if (n <= 1) return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }
}
