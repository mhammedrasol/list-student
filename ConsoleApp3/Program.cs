using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liststudent
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Marks { get; set; }

            public Student(string name, int marks)
            {
                Name = name;
                Marks = marks;
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

          

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\nEnter details for Student :"+i);

                Console.Write("Name: ");
                string name = Console.ReadLine();


                Console.Write("Marks: ");
                int marks = int.Parse(Console.ReadLine());

                students.Add(new Student(name, marks));
            }

            foreach (var student in students)
            {
                if (student.Marks >= 50)
                {
                    Console.WriteLine("THE STUDENT IS PASS:"+student.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
