namespace MySQLLogin
{
    internal static class Program
    {

        static void Main()
        {
            Test(new SQLDB("localhost", "3306", "sakila", "Benex", "111111"));   
        }

        static void Test(IMySql mySql)
        {
            var Actors = mySql.GetActors("select * from actor;");

            foreach (var item in Actors)
            {
                Console.WriteLine($"ID: {item.ID} Firstname: {item.Firstname} Lastname: {item.Lastname}");
            }
        }
    }
}