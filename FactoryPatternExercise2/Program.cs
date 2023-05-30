namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What data would you like to use? A list, SQL, or Mongo?");
            var userInput = Console.ReadLine();

            var response = DataAccessFactory.GetDataAccessType(userInput);
            response.LoadData();
            response.SaveData();
        }
    }
}
