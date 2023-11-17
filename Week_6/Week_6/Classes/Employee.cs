using System;
using System.Collections;
using System.Collections.Generic;

namespace Week_6.Classes
{
    internal class Employee : IEnumerable<Employee>, IEnumerator<Employee>, IComparable<Employee>, IComparer<Employee>, IEquatable<Employee>
    {
        private List<Employee> employees;
        private int position = -1;

        public string firt_name { get; set; }
        public string last_name { get; set; }
        public string id { get; set; }
        public string birthday { get; set; }
        public int age => CalculateAge();
        public string salary { get; set; }
        public string reiting { get; set; }

        public Employee()
        {
            employees = new List<Employee>();
        }

        public Employee(string firt_name, string last_name, string id, string birthday, string salary, string reiting, List<Employee> employees, int position)
        {
            this.firt_name = firt_name;
            this.last_name = last_name;
            this.id = id;
            this.birthday = birthday;
            this.salary = salary;
            this.reiting = reiting;
            this.employees = employees;
            this.position = position;
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Employee Current => employees[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Implement if needed
        }

        public bool MoveNext()
        {
            position++;
            return position < employees.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public int CompareTo(Employee other)
        {
            return this.reiting.CompareTo(other.reiting);
        }

        public int Compare(Employee x, Employee y)
        {
            return x.salary.CompareTo(y.salary);
        }

        public bool Equals(Employee other)
        {
            return this.id.Equals(other.id);
        }

        private int CalculateAge()
        {
            return DateTime.Now.Year - int.Parse(birthday);
        }
    }
}
