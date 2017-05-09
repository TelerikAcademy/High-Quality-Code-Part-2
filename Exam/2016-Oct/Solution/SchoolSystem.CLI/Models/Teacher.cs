using System;

using SchoolSystem.Cli.Models.Abstractions;
using SchoolSystem.Cli.Models.Contracts;
using SchoolSystem.Cli.Models.Enums;

namespace SchoolSystem.Cli.Models
{
    public class Teacher : Person, ITeacher
    {
        public const int MaxStudentMarksCount = 20;

        public Teacher(string firstName, string lastName, Subject subject)
            : base(firstName, lastName)
        {
            this.Subject = subject;
        }

        public Subject Subject { get; set; }

        public void AddMark(IStudent student, float mark)
        {
            if (student.Marks.Count >= MaxStudentMarksCount)
            {
                throw new ArgumentException($"The student's marks count exceed the maximum count of {MaxStudentMarksCount} marks");
            }

            var newMark = new Mark(this.Subject, mark);
            student.Marks.Add(newMark);
        }
    }
}
