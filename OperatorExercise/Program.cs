namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 41;
            var b = 8;

            var quotient = a / b;
            var remainder = a % b;

            
            //Console.WriteLine($"{a} divided by {b} is {quotient} remainder {remainder}");
            Console.WriteLine(a + " / "  + b + " is " + quotient + " remainder " + remainder);

            Console.WriteLine("Please input a radius below.");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }
        public static double AreaOfCircle(double radius)
        {



            //scope of the method below
            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }







    }
}
