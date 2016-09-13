using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;

namespace Guards_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] invalidArgument = new string[] { };
            //string[] invalidArgument = (string[])null;

            //var studentsData = new string[]
            //{
            //    "Moncho tigurcheto_moni@yahoo.com 13",
            //    "Mimi mimi@yahoo.com 14",
            //    "Sashko sasheto@yahoo.com 13"
            //};

            //var students = ParseStudents(studentsData);
            //students.ForEach(Console.WriteLine);

            //var sum = Sum(1, 2);
            //var sum = Sum(0, int.MaxValue / 2);
            //var sum = Sum(627, int.MaxValue / 2 + 1);
            //var sum = Sum(-1, 627);
            //Console.WriteLine(sum);
        }

        public static IEnumerable<Student> ParseStudents(string[] studentsData)
        {
            Guard.WhenArgument(studentsData, "studentsData")
                .IsNullOrEmpty()
                .Throw();

            var students = new List<Student>(studentsData.Length);
            foreach(var studentData in studentsData)
            {
                var studentDataArgs = studentData.Split(' ').ToArray();
                var student = new Student
                {
                    Name = studentDataArgs[0],
                    Email = studentDataArgs[1],
                    Age = int.Parse(studentDataArgs[2])
                };

                students.Add(student);
            }

            return students;
        }

        public static int Sum(int a, int b)
        {
            var maxAllowedValue = int.MaxValue / 2;
            var minAllowedValue = 0;

            Guard.WhenArgument(a, "a").IsLessThan(minAllowedValue).IsGreaterThan(maxAllowedValue).Throw();
            Guard.WhenArgument(b, "b").IsLessThan(minAllowedValue).IsGreaterThan(maxAllowedValue).Throw();

            var sum = a + b;

            return sum;
        }
    }
}
