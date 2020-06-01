using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.ForegroundColor = ConsoleColor.White; 
           Console.WriteLine("Pressione enter para saber a data e a hora atual:");

           Console.ReadKey();

           DateTime DataDoSistema = DateTime.Now;

           Console.Write("Neste momento são exatamente: ");
           Console.ForegroundColor = ConsoleColor.Magenta; 
           Console.WriteLine (DataDoSistema);
        }
    }
}
