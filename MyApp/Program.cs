using System;
using System.Threading;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
            => new Program(false).Run();

        private readonly bool fastMode;

        public Program(bool fastMode)
            => this.fastMode = fastMode;

        public void Run()
        {
            for (int i = 0; true; i++)
            {
                Console.WriteLine($"This is data set {i}");
                Thread.Sleep(fastMode ? 100 : 1000);
            }
        }
    }
}
