namespace OOP22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vvodeti komponenti pervomu vectoru (x y)=>");
            string[] v1Input = Console.ReadLine().Split();
            Vector v1 = new Vector(int.Parse(v1Input[0]), int.Parse(v1Input[1]));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vvodeti komponenti vtoromu vectoru  (x y)=>");
            string[] v2Input = Console.ReadLine().Split();
            Vector v2 = new Vector(int.Parse(v2Input[0]), int.Parse(v2Input[1]));
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sravniniy=>");
            Console.WriteLine($"1 vector ravno 2 ==>  {v1 == v2}");
            Console.WriteLine($"1 vector ne ravno 2 ==> {v1 != v2}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSkalyarnoy umnojiniy=>");
            Vector scaledVector = 3 * v1;
            Console.WriteLine($"({scaledVector.X}, {scaledVector.Y})");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nUmnojiniy =>:");
            int dotProduct = v1 * v2;
            Console.WriteLine(dotProduct);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVectornoy vechitaniy=>");
            Vector subtractionVector = v2 - v1;
            Console.WriteLine($"({subtractionVector.X}, {subtractionVector.Y})");
        }
    }
}

