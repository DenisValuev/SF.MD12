using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

namespace SF.Module12.Unit4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Testing>();
            //Estimate(20);
            Console.ReadKey();
        }

        static void CreateMatrix(int n)
        {
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = i + j;
                }
            }
        }

        static void Estimate(int n)
        {
            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                timer.Restart();

                CreateMatrix(10000);

                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
            }
        }
    }

    public class Testing
    {
        [Benchmark]
        public void CreateMatrix()
        {
            int n = 10000;
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = i + j;
                }
            }
        }

        static int Iterations = 10000;
        [Benchmark]
        public string UseString()
        {
            string value = "";

            for (int i = 0; i < Iterations; i++)
            {
                value += i.ToString();
                value += " ";
            }

            return value;
        }

        [Benchmark]
        public string UseStringBuilder()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Iterations; i++)
            {
                builder.Append(i.ToString());
                builder.Append(" ");
            }

            return builder.ToString();
        }
    }
}
