namespace MultipleIfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score; //We called this as variable declarition
            Console.WriteLine("enter Day number"); //this statement is used to print the data
            score = int.Parse(Console.ReadLine()); //this statement is used to read the datafrom the command prompt and assign score to student
            if (score >= 90)
            {
                Console.WriteLine("You got an A.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("You got a B.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got a C.");
            }

            else if (score < 60)
            {
                Console.WriteLine("You are failed");
            }
            else
            {
                Console.WriteLine("You need to improve your score.");
            }
            Console.ReadLine();
        }
    }
}
