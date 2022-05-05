using System;
using System.Diagnostics;
using System.Text;

namespace EstudoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            long timeString = MostraQueStringEhImutavel();

            long timeInteger = MostarQueIntegerEhMuatavel();

            Console.WriteLine($"Time String = {timeString} || Time Integer = {timeInteger}");

            long concatenacaoStrings = ConcatenacaoStrings();

            long concatenacaoStringsComStringBuilder = ConcatenacaoStringsComStringBuilder();

            Console.WriteLine($"Time Concat Strings = {concatenacaoStrings} || Time Concat Strings With StringBuilder = {concatenacaoStringsComStringBuilder}");

            Console.ReadKey();
        }

        private static long ConcatenacaoStringsComStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 3000000; i++)
            {
                stringBuilder.Append("DotNet Tutorials");
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended concat strings with StringBuilder");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        private static long ConcatenacaoStrings()
        {
            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                str = "DotNet Tutorials" + str;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended concat strings");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        private static long MostarQueIntegerEhMuatavel()
        {
            int ctr = 0;
            Console.WriteLine("Loop Integer Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                ctr = ctr + 1;
                // Console.WriteLine(ctr);
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended Integer");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        private static long MostraQueStringEhImutavel()
        {
            string str = "";
            Console.WriteLine("Loop String Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
                // Console.WriteLine(str);
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended String");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        private static void MostraTamanhoDeUmTipo()
        {
            Console.WriteLine($"Tamanho do tipo inteiro, {sizeof(int)}");
            Console.ReadKey();
        }
    }
}
