namespace Fibonacci
{
    using NUnit.Framework;
    class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]

        public void Should_return_0_for_position_0(int position, int expectedFibonacci)
        {
            var fibonacci = new Fibonacci();
            int fib = fibonacci.GenerateFibonacciNumberForPosition(position);
            Assert.That(fib, Is.EqualTo(expectedFibonacci));
        }
    }
}
