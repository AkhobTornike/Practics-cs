using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_6.Classes;

namespace Week_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Employee employee1 = new Employee("John", "Doe", "123456789", "1990-05-15", "50000", "4", employeeList, 0);
            Employee employee2 = new Employee("Jane", "Smith", "987654321", "1985-08-22", "60000", "5", employeeList, 0);
            Employee employee3 = new Employee("Bob", "Johnson", "111223344", "1988-03-10", "55000", "3", employeeList, 0);

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            employeeList.Sort(employee1);

            employeeList.Sort(employee2);

            employeeList.Sort(employee3);

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.firt_name} {employee.last_name} - Rating: {employee.reiting}, Salary: {employee.salary}");
            }
        }
    }
}
