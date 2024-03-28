namespace Task13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("СПб, Невский проспект 19-20", 30, 10, 120);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("СПб, Московский проспект 14-15", 50, 15, 20, 5);
            Console.WriteLine(multiBuilding.Print());
        }
    }
}