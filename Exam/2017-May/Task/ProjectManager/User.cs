using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectManager.Models
{
    public class User
    {
        [Required(ErrorMessage = "User Username is required!")]
        public string UN { get; set; }
        [Required(ErrorMessage = "User Email is required!")]
        [EmailAddress(ErrorMessage = "User Email is not valid!")]
        string Email { get; set; }
        public User(string username, string email)
        {
            this.UN = username;
            this.Email = email;
        }
        public override string ToString()
        {
            var b = new StringBuilder();
            b.AppendLine("    Username: " + this.UN);
            b.AppendLine("    Email: " + this.Email);
            return b.ToString();
        }
    }
}
