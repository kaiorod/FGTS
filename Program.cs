using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, fgts;

            Console.Clear();
            Console.Beep();

            Console.Write("Digite o salário : ");
            sal = double.Parse(Console.ReadLine());

            fgts = sal * 0.08;

            Console.Clear();
            Console.WriteLine($"Salário : {sal:C2}");
            Console.Write($"FGTS : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{fgts:C2}");
            Console.ResetColor();
        }
    }
}
