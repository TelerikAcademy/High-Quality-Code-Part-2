using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Models
{
    public class Task
    {
        [Required(ErrorMessage = "Task Name is required!")]
        public string nm { get; set; }
        [Required(ErrorMessage = "Task Owner is required")]
        public User own { get; set; }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine("    Name: " + this.nm);
            builder.Append("    State: " + this.st);

            return builder.ToString();
        }
        public string st { get; set; }
        public Task(string name, User owner, string state)
        {
            this.nm = name;
            this.own = owner;
            this.st = state;
        }
    }
}
