namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstName = "Heather";
            int myAge = 33;
            char middleInitial = 'M';
            bool x = true;
            double myWeight = 130;
            decimal myWeight2 = 125;

            Console.WriteLine($"My first name is {myFirstName}, I am {myAge} years old");
            Console.WriteLine($"My middle name is {middleInitial} and this is {x} in all instances");
            Console.WriteLine($"My weight fluctuates from {myWeight2} to {myWeight} every day");

        }
    }
}