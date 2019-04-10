using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Employee employee1 = new Employee();
                employee1.FirstName = "Joe";
                employee1.LastName = "Joperson";
                employee1.ID = 563479;

                Employee employee2 = new Employee();
                employee2.FirstName = "Joe";
                employee2.LastName = "Jeperson";
                employee2.ID = 573924;

                Employee employee3 = new Employee();
                employee3.FirstName = "Pepe";
                employee3.LastName = "Silvia";
                employee3.ID = 798345;

                Employee employee4 = new Employee();
                employee4.FirstName = "Piano";
                employee4.LastName = "Yokohama";
                employee4.ID = 789432;

                Employee employee5 = new Employee();
                employee5.FirstName = "Sleve";
                employee5.LastName = "McDichael";
                employee5.ID = 652443;

                Employee employee6 = new Employee();
                employee6.FirstName = "Karl";
                employee6.LastName = "Dandleton";
                employee6.ID = 289272;

                Employee employee7 = new Employee();
                employee7.FirstName = "Glenallen";
                employee7.LastName = "Mixon";
                employee7.ID = 123296;

                Employee employee8 = new Employee();
                employee8.FirstName = "Tony";
                employee8.LastName = "Hawk";
                employee8.ID = 136129;

                Employee employee9 = new Employee();
                employee9.FirstName = "Bobson";
                employee9.LastName = "Dugnutt";
                employee9.ID = 178716;

                Employee employee10 = new Employee();
                employee10.FirstName = "Anatoli";
                employee10.LastName = "Smorin";
                employee10.ID = 576236;

                List<Employee> employees = new List<Employee>(); // adding all the employees to a list
                employees.Add(employee1);
                employees.Add(employee2);
                employees.Add(employee3);
                employees.Add(employee4);
                employees.Add(employee5);
                employees.Add(employee6);
                employees.Add(employee7);
                employees.Add(employee8);
                employees.Add(employee9);
                employees.Add(employee10);

                //List<Employee> joeList = new List<Employee>();

                //foreach (Employee employee in employees) //adding any employee on the list named joe to a new list of joes
                //{
                //    if (employee.FirstName == "Joe")
                //    {
                //        joeList.Add(employee);
                //    }
                //}
                //foreach (Employee joe in joeList)
                //{
                //    Console.WriteLine(joe.FirstName + " " + joe.LastName);
                //}

                List<Employee> joes = employees.Where(name => name.FirstName == "Joe").ToList(); //adding any employee "where" the FirstName is joe to a new list of joes using a lambda expression
                foreach (Employee joe in joes)
                {
                    Console.WriteLine(joe.FirstName + " " + joe.LastName);
                }


                Console.ReadKey();
            }
        }
    }
}
