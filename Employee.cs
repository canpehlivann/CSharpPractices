using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaFunctions
{
    public class Employee
    {
        private readonly List<EmployeeModel> allEmployees;
        public Employee() //HACK: I think now without doing something hard no one can access neither allEmployees nor props.

        {
            allEmployees = new List<EmployeeModel>
            {
                new EmployeeModel { FirstName = "Joey", LastName = "Tribbiani", ID = 1 },

                new EmployeeModel { FirstName = "Rachel", LastName = "Green", ID = 2 },

                new EmployeeModel { FirstName = "Phoebe", LastName = "Buffay", ID = 3 },

                new EmployeeModel { FirstName = "Chandler", LastName = "Bing", ID = 4 },

                new EmployeeModel { FirstName = "Ross", LastName = "Geller", ID = 5 },

                new EmployeeModel { FirstName = "Monica", LastName = "Geller", ID = 6 },

                new EmployeeModel { FirstName = "Fred", LastName = "Flintstone", ID = 7 },

                new EmployeeModel { FirstName = "Wilma", LastName = "Flintstone", ID = 8 },

                new EmployeeModel { FirstName = "Barney", LastName = "Rubble", ID = 9 },

                new EmployeeModel { FirstName = "Betty", LastName = "Rubble", ID = 10 },

                new EmployeeModel { FirstName = "Joe", LastName = "Swanson", ID = 11 },

                new EmployeeModel { FirstName = "Stewie", LastName = "Griffin", ID = 12 }
            };
        }   

       
        private List<EmployeeModel> ExtractJoesWithoutLambda()
        {
            var startTime = DateTime.Now.Millisecond;

            foreach (var employee in allEmployees)
            {
                if (employee.FirstName.ToLower().Contains("joe") == false)
                {
                    allEmployees.Remove(employee);
                    break;
                }
            }

            var finishTime = DateTime.Now.Millisecond;

            var elapsedTime = finishTime - startTime;

            var elapsedTimeString = elapsedTime.ToString();

            Console.WriteLine($"Time elapsed in operation without lambda: {elapsedTimeString}\n");

            return allEmployees;
        }

        public void PrintJoes()
        {
            var allEmployees = ExtractJoesWithoutLambda();
            foreach (var employee in allEmployees)
            {
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}, ID: {employee.ID}, Full Name: {employee.FullName}\n");
            }
        
        }

        private List<EmployeeModel> ExtractJoesWithLambda()
        {
            var startTime = DateTime.Now.Millisecond;

            var employees = allEmployees.Where(x => x.FirstName.ToLower().Contains("joe")).ToList();

            var finishTime = DateTime.Now.Millisecond;

            var elapsedTime = finishTime - startTime;

            var elapsedTimeString = elapsedTime.ToString();

            Console.WriteLine($"Time elapsed in operation with lambda: {elapsedTimeString}\n");

            return employees;
        }

        public void PrintJoesWithLambda()
        {
            var allEmployees = ExtractJoesWithLambda();

            //TODO: Bad practice. Better to print it by using lambdas.
            foreach( var employee in allEmployees )
            {
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}, ID: {employee.ID}, Full Name: {employee.FullName}\n");
            }
        }
        private List<EmployeeModel> ExtractIDsGreaterThanID(int ID)
        {
            var startTime = DateTime.Now.Millisecond;

            var employees = allEmployees.Where(x => x.ID > ID).ToList();

            var finishTime = DateTime.Now.Millisecond;

            var elapsedTime = finishTime - startTime;

            var elapsedTimeString = elapsedTime.ToString();

            Console.WriteLine($"Time elapsed in operation with lambda: {elapsedTimeString}\n");

            return employees;
        }

        public void PrintEmployeesFoundByID(int ID)
        {
            var allEmployees = ExtractIDsGreaterThanID(ID);

            foreach (var employee in allEmployees)
            {
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}, ID: {employee.ID}, Full Name: {employee.FullName}\n");
            }
        }
    }
}

