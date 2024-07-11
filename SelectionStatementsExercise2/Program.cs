using System.Threading.Channels;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is so rewarding!");
                    break;
                case "english":
                    Console.WriteLine("English gives you a lot of skills for the workplace.");
                    break;
                case "science":
                    Console.WriteLine("Science is an amazing teacher!");
                    break;
                case "history":
                    Console.WriteLine("History can guide our future.");
                    break;
                case "psychology":
                    Console.WriteLine("Psychology is a mind trip!");
                    break;
                default:
                    Console.WriteLine("I love that. No education is ever wasted");
                    break;
            }
        }
    }
}