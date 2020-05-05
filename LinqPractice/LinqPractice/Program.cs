using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> employeelist = new List<Employee>() {
                new Employee() { EMPLOYEE_ID = 1, FirstName = "John",LastName = "Abraham",Salary = 1000000,JoiningDate="01-JAN-12 12.00.00 AM",Department="Banking"} ,
                new Employee() { EMPLOYEE_ID = 2, FirstName = "Michael ",LastName = "Clarke",Salary = 800000,JoiningDate="01-JAN-12 12.00.00 AM",Department="Insurance"} ,
                new Employee() { EMPLOYEE_ID = 3, FirstName = "Roy",LastName = "Thomes",Salary = 700000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Banking"} ,
                new Employee() { EMPLOYEE_ID = 4, FirstName = " Tom",LastName = "Jose",Salary = 600000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Insurance"} ,
                new Employee() { EMPLOYEE_ID = 5, FirstName = " Jerry",LastName = "Pinto",Salary = 650000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Insurance"} ,
                new Employee() { EMPLOYEE_ID = 6, FirstName = " Philip",LastName = "Mathew",Salary = 750000,JoiningDate="01-JAN-13 12.00.00 AM",Department="Service"} ,
                new Employee() { EMPLOYEE_ID = 7, FirstName = "TestName1",LastName = "123",Salary = 650000,JoiningDate="01-JAN-13 12.00.00 AM",Department="Service"} ,
                new Employee() { EMPLOYEE_ID = 8, FirstName = "TestName2",LastName = "Lname%",Salary = 600000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Insurance"} ,


            };

            // LINQ Query Syntax to find out teenager students
            IEnumerable<Employee> q1 =
                         from s in employeelist
                         select s;

            Console.WriteLine("Employee list:");

            foreach (Employee std in q1)
            {

                Console.WriteLine(std.EMPLOYEE_ID + ", " + std.FirstName +
                     ", " + std.LastName + ", " + std.JoiningDate + ", " + std.Salary + ", " + std.Department);
            }
            Console.WriteLine("FirstName And LastName of employee:-");
            foreach (Employee std in q1)
            {

                Console.WriteLine(std.EMPLOYEE_ID + ", " + std.FirstName +
                     ", " + std.LastName);
            }

            Console.WriteLine("FirstName into Lower");

            foreach (Employee std in q1)
            {

                Console.WriteLine(std.EMPLOYEE_ID + ", " + std.FirstName.ToLower()
                     );
            }
            Console.WriteLine("FirstName into Upper");

            foreach (Employee std in q1)
            {

                Console.WriteLine(std.EMPLOYEE_ID + ", " + std.FirstName.ToUpper()
                     );
            }
            Console.WriteLine("Unique value of department:-");
            var otherDistinct = employeelist.Select(p => p.Department).Distinct();
            foreach (var str in otherDistinct)
            {

                Console.WriteLine(str);
            }

            foreach (Employee std in q1)
            {

                Console.WriteLine(std.FirstName.Substring(0, 3)
                     );
            }

            Console.WriteLine("Potition of o :-");


            var result = employeelist
         .Where(st => st.FirstName.ToLower().Contains("o"))
         ;

            foreach (var std in result)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.FirstName.ToLower().IndexOf("o"));

            }
            Console.WriteLine("Remove White space from right ");
            foreach (var std in result)
            {
                Console.WriteLine(std.FirstName.TrimEnd());


            }

            Console.WriteLine("Removing White space from left");
            foreach (var std in result)
            {
                Console.WriteLine(std.FirstName.TrimStart());


            }
            Console.WriteLine("Length of the FirstName");
            foreach (Employee std in q1)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.FirstName.Length
                     );
            }
            Console.WriteLine("Replace o with $ :-");
            foreach (Employee std in q1)
            {

                Console.WriteLine(std.FirstName.ToLower().Replace("o", "$")
                     );
            }

            Console.WriteLine("First Name & last Name seperated by _ :-");

            foreach (Employee std in q1)
            {
                var st = string.Join("_", std.FirstName, std.LastName);
                Console.WriteLine(st
                     );
            }
            Console.WriteLine("Assending order");
            IEnumerable<Employee> q2 =
                         from s in employeelist
                         orderby s.FirstName ascending
                         select s;
            foreach (Employee std in q2)
            {

                Console.WriteLine(std.FirstName);

            }
            Console.WriteLine("decending order");
            IEnumerable<Employee> q3 =
                         from s in employeelist
                         orderby s.FirstName descending
                         select s;
            foreach (Employee std in q3)
            {

                Console.WriteLine(std.FirstName);

            }
            Console.WriteLine("FirstName assending and salary decending order");
            IEnumerable<Employee> q4 =
                         from s in employeelist
                         orderby s.Salary descending
                         select s;
            foreach (Employee std in q4)
            {

                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.Salary);

            }
            Console.WriteLine("FirstName is john");
            var res = from s in employeelist
                      where s.FirstName == "John"
                      select s;
            foreach (var std in res)
            {
                Console.WriteLine(std.FirstName);


            }
            Console.WriteLine("FirstName is john and roy");
            var res1 = from s in employeelist
                       where s.FirstName == "John" || s.FirstName == "Roy"
                       select s;
            foreach (var std in res1)
            {
                Console.WriteLine(std.FirstName);
            }
            Console.WriteLine("FirstName is not john and roy");
            var res2 = from s in employeelist
                       where s.FirstName != "John" && s.FirstName != "Roy"
                       select s;
            foreach (var std in res2)
            {
                Console.WriteLine(std.FirstName);


            }

            Console.WriteLine("FirstName Starts with J");
            var res3 = from s in employeelist
                       where s.FirstName.StartsWith("J")
                       select s;
            foreach (var std in res3)
            {
                Console.WriteLine(std.FirstName);


            }

            Console.WriteLine("FirstName of o :-");




            foreach (var std in result)
            {
                Console.WriteLine(std.FirstName);
            }

            Console.WriteLine("FirstName ends with n");
            var res4 = from s in employeelist
                       where s.FirstName.EndsWith("n")
                       select s;
            foreach (var std in res4)
            {
                Console.WriteLine(std.FirstName);
            }
            Console.WriteLine("FirstName ends with n and have 4 letters");
            var res5 = from s in employeelist
                       where s.FirstName.EndsWith("n") && s.FirstName.Length == 4
                       select s;
            foreach (var std in res5)
            {
                Console.WriteLine(std.FirstName);
            }
            Console.WriteLine("Salary  is greater than 600000");
            var res6 = from s in employeelist
                       where s.Salary > 600000
                       select s;
            foreach (var std in res5)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.Salary);
            }
            Console.WriteLine("Salary  is less than 800000");
            var res7 = from s in employeelist
                       where s.Salary < 800000
                       select s;
            foreach (var std in res7)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.Salary);
            }
            Console.WriteLine("Salary  is between 500000 and 800000");
            var res8 = from s in employeelist
                       where s.Salary > 500000 && s.Salary < 800000
                       select s;
            foreach (var std in res8)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.Salary);
            }
            Console.WriteLine("FirstName is john and Michael");
            var res9 = from s in employeelist
                       where s.FirstName == "John" || s.FirstName == "Michael "
                       select s;
            foreach (var std in res9)
            {
                Console.WriteLine(std.FirstName + "-" + std.LastName + "-" + std.Salary + "-" + std.JoiningDate + "-" + std.Department);
            }
            Console.WriteLine("Get details where joining month is 2013");
            var res10 = from s in employeelist

                        select s;
            foreach (var std in res10)
            {
                DateTime dt = Convert.ToDateTime(std.JoiningDate);

                string s2 = dt.ToString("dd-MM-yyyy");

                DateTime dtnew = Convert.ToDateTime(s2);
                if (dt.Year == 2013)
                    Console.WriteLine(dtnew + ", " + std.FirstName);
            }
            Console.ReadLine();

        }
    }
}
    