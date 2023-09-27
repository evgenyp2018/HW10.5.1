using System;


namespace HW10._5._1
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            ILogger Logger = new Logger();
            Summ summ = new Summ(Reader.Read(), Reader.Read());
            if (summ.X == 0 || summ.Y == 0)
            {
                Logger.Error();
                Console.WriteLine("Рассчитать сумму невозможно");
            }
            else
            {
                Logger.Event();
                Console.WriteLine($"Результат сложения: {summ.Sum(summ.X, summ.Y)}");
            }
        }
    }
}