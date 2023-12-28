namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Please choose a type of database that you want to use. (List, Sql or Mongo");
                answer = Console.ReadLine();
            } while ((answer.ToLower() != "list") && (answer.ToLower() != "sql") && (answer.ToLower() != "mongo"));

            IDataAccess chosenDatabase = DataAccessFactory.GetDataAccessType(answer);

            Console.WriteLine();
            chosenDatabase.LoadData();
            Console.WriteLine();
            chosenDatabase.SaveData();
        }
    }
}
