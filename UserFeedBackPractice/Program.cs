namespace UserFeedBackPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" What is your name? ");
            string name = Console.ReadLine();
            Console.Write(" favorite color? ");
            string colour = Console.ReadLine();


            // Allows Users to put in infomartion that will print to the screen


            Console.WriteLine("Hello " + name + " your favorite color is " + colour);

        }
    }
}