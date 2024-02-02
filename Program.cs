using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaFunctions
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("-Let's extract of list of employees named \"Joe\" using a foreach loop:");

            Employee employee = new Employee();

            employee.PrintJoes();

            Console.WriteLine("-Now, let's do the same thing using a lambda function:");

            employee.PrintJoesWithLambda();

            Console.WriteLine("-Now, let's use a lambda function to extract a list of employees whose ID > 5:");

            var ID = 5;

            employee.PrintEmployeesFoundByID(ID);

            Console.WriteLine("To close the program hit enter");

            var exitKey = Console.ReadKey(true);

            do
            {
                if (exitKey.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Good Bye!");

                    Environment.Exit(0);
                }

                else
                {
                    exitKey = Console.ReadKey(true);
                }

            } while (exitKey.Key != ConsoleKey.Enter );
        }
    }
}
