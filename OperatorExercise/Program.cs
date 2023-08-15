using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        //----------------------Exercise 2-------------------------
        // define a method called AreaOfCircle 
        public static double AreaOfCircle(double radius)

        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
        static void Main(string[] args)
        {
            ///------------------------Exercise 1--------------------
            // For division create 2 variables a and b
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine( a + " / " + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle.");
            

            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }
    }
}
  