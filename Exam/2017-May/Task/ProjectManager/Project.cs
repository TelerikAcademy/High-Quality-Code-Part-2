using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Models
{
    public class Project : IProject
    {
        
        
        [Required(ErrorMessage = "Project Name is required!")]
        public string Name { get; set; }
        [Range(typeof(DateTime), "1800-1-1", "2017-1-1", ErrorMessage = "Project StartingDate must be between 1800-1-1 and 2017-1-1!")]
        public DateTime StartingDate { get; set; }
        [Range(typeof(DateTime), "2018-1-1", "2144-1-1", ErrorMessage = "Project EndingDate must be between 2018-1-1 and 2144-1-1!")]
        public DateTime EndingDate { get; set; }        
        public string State { get; set; }
        public Project(string name, DateTime startingDate, DateTime endingDate, string state)
        {
            Name = name;
            StartingDate = startingDate;
            EndingDate = endingDate;
            State = state;
            Users = new List<User>();
            Tasks = new List<Task>();
        }
        public virtual List<User> Users { get; set; }
        public override string ToString()
        {
            var b = new StringBuilder();
            b.AppendLine("Name: " + this.Name);
            b.AppendLine("  Starting date: " + this.StartingDate.ToString("yyyy-MM-dd"));
            b.AppendLine("  Ending date: " + this.EndingDate.ToString("yyyy-MM-dd"));
            b.AppendLine("  State: " + this.State);
            b.AppendLine("  Users: ");

            b.Append(string.Join(Environment.NewLine + "  -------------" + Environment.NewLine, this.Users));

            if (this.Users.Count == 0)
                b.AppendLine("  - This project has no users!");
            b.AppendLine("  Tasks: ");
            b.Append(string.Join(Environment.NewLine + "  -------------" + Environment.NewLine, this.Tasks));

            if (this.Tasks.Count == 0)
                b.Append("  - This project has no tasks!");

            return b.ToString();
        }
        public virtual List<Task> Tasks { get; set; }

    }
}


