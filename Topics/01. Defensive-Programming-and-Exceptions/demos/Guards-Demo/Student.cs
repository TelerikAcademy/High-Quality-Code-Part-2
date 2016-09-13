using System.Text;

namespace Guards_Demo
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"Name: {this.Name}");
            builder.AppendLine($"Email: {this.Email}");
            builder.AppendLine($"Age: {this.Age}");

            return builder.ToString();
        }
    }
}
