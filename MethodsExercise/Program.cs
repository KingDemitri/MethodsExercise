namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, New User. Welcome to Exercise 1.");



            Console.WriteLine("What is your name?"); // output
            var name = Console.ReadLine(); // input

            Console.WriteLine("Where are you from?"); // output
            Console.ReadLine(); // input

            Console.WriteLine("What is one of your favorite foods?"); // output
            Console.ReadLine(); // input

            Console.WriteLine("What do you like about it?"); // output
            Console.ReadLine(); // input

            Console.WriteLine("Is it something you can get nearby?"); // output
            Console.ReadLine(); // input

            Console.WriteLine("Thank you for your time."); // output

            ////-----------------Ex 2-----------------------------
            ////Method Calls

            Console.Write(Methods.Add(3, 7));
            Methods.Multiply(3, 7);
            var answer = Methods.Subtract(20, 10);
            Console.WriteLine($"20 - 10 = {answer}");

            //Console.ReadLine();

            Methods.AddWithParam(5, 5, 5, 5, 5, 5, 5);

            //I THINK this was everything required for the exercise.
            //I haven't uploaded it because I wanted to truly understand methods before doing so. 
            //I understood this assignment since it was something simple like Addition, Subtraction, etc.

        }
    }
}
