using System;

namespace DependencyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectDep.SomeClass.AMethodThatCallsSqlClient();
        }
    }
}
