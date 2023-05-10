namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Jasper";
            int dogAge = 5;
            char dogInitial = 'J';
            bool goodBoy = true;
            double fortySpeed = 4.02;
            decimal dogHeight = 1.0m;
            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old. ");
            Console.WriteLine($"His name begins with a {dogInitial}, and it is {goodBoy} that he is a good boy. ");
            Console.WriteLine($"Additionally, he is {dogHeight}m tall with a {fortySpeed}s forty yard dash time.");
        }
    }
}
