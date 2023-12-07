using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Week_7.Classes;

namespace Week_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "John", "Doe", 20),
                new Student(2, "Jane", "Smith", 22),
                new Student(3, "Bob", "Johnson", 21)
            };

            SerializeToXml(students, "students.xml");

            Console.WriteLine("XML file created successfully.");

            List<Student> deserializedStudents = DeserializeFromXml<List<Student>>("students.xml");
            ProcessQueries(deserializedStudents);
        }

        // create SerializeToXml function
        static void SerializeToXml<T>(T obj, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, obj);
            }
        }
        static T DeserializeFromXml<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextReader reader = new StreamReader(fileName))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        static void ProcessQueries(List<Student> students)
        {
            var query1 = students.Where(s => s.Age > 20);
            var query2 = students.OrderBy(s => s.LastName);
            var query3 = students.GroupBy(s => s.Age);

            Console.WriteLine("Students older than 20:");
            foreach (var student in query1)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}");
            }

            Console.WriteLine("\nStudent sorted by last name:");
            foreach (var student in query2)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}");
            }

            Console.WriteLine("Students group by age:");
            foreach (var group in query3)
            {
                Console.WriteLine($"Age Group: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"    {student.FirstName} {student.LastName}, Age: {student.Age}");
                }
            }
        }
    }
}
