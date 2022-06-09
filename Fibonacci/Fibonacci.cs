namespace Fibonacci
{
    public class Fibonacci
    {
        public int GenerateFibonacciNumberForPosition(int pos)
        {
            if (pos == 0 || pos == 1)
            {
                return pos;
            }

            return GenerateFibonacciNumberForPosition(pos - 1) + GenerateFibonacciNumberForPosition(pos - 2);

        }
    }
}
