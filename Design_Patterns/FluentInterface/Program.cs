using System;

namespace Design_Patterns.FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new FluentEmployee();
            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");

            Console.WriteLine(obj);
        }
    }
}
