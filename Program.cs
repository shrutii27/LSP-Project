using LSPSolutionApp.Model;

namespace LSPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowFlightDetails(new Sparrow("Brown"));
            ShowFlightDetails(new Pigeon("Grey"));
            ShowWalkDetails(new Ostrich("Black"));
            ShowSwimWalkDetails(new Duck("Yellow"));
        }
         static void ShowFlightDetails(IFlyable bird)
        {
            Console.WriteLine($"This bird colour is {bird.BodyColor}...");
            bird.Fly();
            Console.WriteLine("--------------------------------------");
        }
        static void ShowWalkDetails(INonFlyable bird)
        {
            Console.WriteLine($"This bird colour is {bird.BodyColor}...");
            bird.Walk();
            Console.WriteLine("--------------------------------------");
        }
        static void ShowSwimWalkDetails(ISwimmable bird)
        {
            Console.WriteLine($"This bird colour is {bird.BodyColor}...");
            bird.Swim();
            bird.Walk();
            Console.WriteLine("--------------------------------------");
        }
    }
}