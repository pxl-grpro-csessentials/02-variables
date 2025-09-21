namespace Frisdrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"Ingeworpen bedrag: {2:c}");
            Console.Write("Prijs van de gekozen frisdrank: € ");
            decimal price = decimal.Parse(Console.ReadLine());

            int change = 200 - (int)(price * 100);
            Console.WriteLine($"Wisselgeld: {change / 100M:c}");

            int coins = change / 100;
            Console.WriteLine($"Munten van 1 euro: {coins}");
            change -= 100;

            coins = change / 50;
            Console.WriteLine($"Munten van 50 cent: {coins}");
            change -= coins * 50;

            coins = change / 20;
            Console.WriteLine($"Munten van 20 cent: {coins}");
            change -= coins * 20;

            coins = change / 10;
            Console.WriteLine($"Munten van 10 cent: {coins}");
            change -= coins * 10;

            coins = change / 5;
            Console.WriteLine($"Munten van 5 cent: {coins}");
            change -= coins * 5;

            coins = change / 2;
            Console.WriteLine($"Munten van 2 cent: {coins}");
            change -= coins * 2;

            coins = change;
            Console.WriteLine($"Munten van 1 cent: {coins}");
        }
    }
}
