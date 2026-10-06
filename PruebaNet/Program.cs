namespace PruebaNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como te llamas?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Holaaaaaa, {name}, hoy es {currentDate:d} y son las {currentDate:t}! de la cdmx");
            Console.Write($"{Environment.NewLine}Presiona enter para salir...");
            Console.Read();
        }
    }
}
