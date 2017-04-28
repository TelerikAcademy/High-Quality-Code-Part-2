using ConsoleApplication3;
using ConsoleApplication3;
using ConsoleApplication3;
using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    class CreateTeacherCommand : ICommand
    {



        public string Execute(IList<string> para)
        {
            // TODO: too drunk, implement later
            throw new NotImplementedException();
        }
    }

    class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> paras)
        {
            Engine.students.Remove(int.Parse(paras[0]));
            return $"Student with ID {int.Parse(paras[0])} was sucessfully removed.";
        }
    }

    class CreateStudentCommand
    {
        public static int id = 0;
        public string Execute(IList<string> para)
        {
            Engine.students.Add(id, new Student(para[0], para[1], (Grade) int.Parse(para[2])));
            return $"A new student with name {para[0]} {para[1]}, grade {(Grade) int.Parse(para[2])} and ID {id++} was created.";
        }
    }

    class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {            
            return Engine.students[int.Parse(parameters[0])].ListMarks();
        }
    }
    class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> prms)
        {
            var teecherid = int.Parse(prms[0]);
            var studentid = int.Parse(prms[1]);
            // Please work
            var student = Engine.students[teecherid];
            var adhyaapak = Engine.teachers[studentid];
            adhyaapak.AddMark(student, float.Parse(prms[2]));
            return $"Teacher {adhyaapak.fName} {adhyaapak.lName} added mark {float.Parse(prms[2])} to student {student.fNeim} {student.lNeim} in {adhyaapak.subject}.";
        }
    }
}
