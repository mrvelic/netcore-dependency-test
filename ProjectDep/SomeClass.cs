using System;
using System.Data.SqlClient;

namespace ProjectDep
{
    public class SomeClass
    {
        public static void AMethodThatCallsSqlClient()
        {
            var whatever = SqlClientFactory.Instance;
            Console.WriteLine(whatever.ToString());
        }
    }
}
