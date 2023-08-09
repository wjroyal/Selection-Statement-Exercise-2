namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var favSub = Console.ReadLine();

            if (favSub == "Math")
            {
                Console.WriteLine($"{favSub} is all about arithmetic.");
            }
            else if (favSub == "English")
            {
                Console.WriteLine($"{favSub} is so important to a student's academic journey.");
            }
            else if (favSub == "Biology")
            {
                Console.WriteLine($"Many students have to dissect an animal in {favSub} class.");
            }
            else if (favSub == "Chemistry")
            {
                Console.WriteLine($"If you are taking {favSub}, be sure to wear proper PPE!");

            }
            else if (favSub == "P.E.")
            {
                Console.WriteLine($"Make sure to stretch before and after {favSub}.");
            }
            else
            {
                Console.WriteLine($"{favSub} is an awesome class. Make sure to study hard!");
            }
        }
    }
}