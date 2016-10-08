using System;
using System.Collections.Generic;
using SchoolSystem.Cli.Core.Commands.Contracts;

namespace SchoolSystem.Cli.Core.Commands
{
    public class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            Engine.Students.Remove(studentId);
            return $"Student with ID {studentId} was sucessfully removed.";
        }
    }
}
