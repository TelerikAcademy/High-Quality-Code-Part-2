using System.Collections.Generic;
using SchoolSystem.Cli.Core.Commands.Contracts;
using SchoolSystem.Cli.Models;
using SchoolSystem.Cli.Models.Enums;

namespace SchoolSystem.Cli.Core.Commands
{
    public class CreateStudentCommand : ICommand
    {
        private static int currentStudentId = 0;

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var student = new Student(firstName, lastName, grade);
            Engine.Students.Add(currentStudentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentStudentId++} was created.";
        }
    }
}
