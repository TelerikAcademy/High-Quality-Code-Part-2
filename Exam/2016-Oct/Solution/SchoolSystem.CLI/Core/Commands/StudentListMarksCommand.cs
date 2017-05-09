using System.Collections.Generic;
using SchoolSystem.Cli.Core.Commands.Contracts;

namespace SchoolSystem.Cli.Core.Commands
{
    public class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var student = Engine.Students[studentId];
            return student.ListMarks();
        }
    }
}
