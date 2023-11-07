namespace Algorithms_and_Big_O_Notation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms algorithms = new Algorithms();
            List<string> names = new List<string>() { "Don", "Abby", "Jeff" };
            algorithms.Repeats(names);

        }
    }
}