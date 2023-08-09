namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favSub = Console.ReadLine();

            switch (favSub.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math");
                    break;

                case "science":
                    Console.WriteLine("I love science");
                    break;

                case "pe":
                    Console.WriteLine("PE is the best");
                    break;

                case "history":
                    Console.WriteLine("History is fun");
                    break;

                case "english":
                    Console.WriteLine("English is boring");
                    break;

                default:
                    Console.WriteLine("I don't know that subject");
                    break;
            }
            
        }
    }
}