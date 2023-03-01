namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int guess;





            Console.WriteLine("Hello! It is time to play a cool guessing game!");




            do
            {
                Console.WriteLine("Pick a number between 1 and 1000");
                guess = int.Parse(Console.ReadLine());


                if (guess > favNumber)
                {
                    Console.WriteLine($"The number {guess} is too high! Try again.");
                }
                else if (guess < favNumber)
                {
                    Console.WriteLine($"The number {guess} is too low! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! {guess} is the correct number!");
                }
            }
            while (guess != favNumber);
        }
    }
}
