using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;
namespace ProjectManager.Models
{
    public interface IProject    {        string Name { get; set; }        DateTime StartingDate { get; set; }        DateTime EndingDate { get; set; }        string State { get; set; }

        List<User> Users { get; set; }        List<Task> Tasks { get; set; }
    }
}
