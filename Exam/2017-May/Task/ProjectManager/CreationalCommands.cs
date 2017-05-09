using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;
using ProjectManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands
{

    public sealed class CreateTaskCommand : ICommand
    {
        public string Execute(List<string> prms)
        {
            var db = new Database();

            var zavoda = new ModelsFactory();

            if (prms.Count != 4) throw new UserValidationException("Invalid command parameters count!");

            if (prms.Any(x => x == string.Empty)) throw new UserValidationException("Some of the passed parameters are empty!");
            
            var pj = db.Projects[int.Parse(prms[0])];

            var owner = pj.Users[int.Parse(prms[1])];

            var task = zavoda.CreateTask(owner, prms[2], prms[3]);
            pj.Tasks.Add(task);

            return "Successfully created a new task!";
        }
    }

    public class CreateProjectCommand : ICommand
    {
        public Database db;
        public ModelsFactory zavod;

        public string Execute(List<string> prms)
        {
            if (prms.Count != 4) throw new UserValidationException("Invalid command parameters count!");
            if (prms.Any(x => x == string.Empty)) throw new UserValidationException("Some of the passed parameters are empty!");
            if (db.Projects.Any(x => x.Name == prms[0])) throw new UserValidationException("A project with that name already exists!");

            var project = zavod.CreateProject(prms[0], prms[1], prms[2], prms[3]);
            db.Projects.Add(project);

            return "Successfully created a new project!";
        }

        public CreateProjectCommand(Database database, ModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();
            Guard.WhenArgument(
                factory, "CreateProjectCommand ModelsFactory")
                .IsNull().Throw();

            db = database; zavod = factory;
        }
    }

    public class CreateUserCommand : ICommand
    {

        public string Execute(List<string> prms)
        {
            var db = new Database();

            var zavoda = new ModelsFactory();

            if (prms.Count != 3) throw new UserValidationException("Invalid command parameters count!");
            if (prms.Any(x => x == string.Empty)) throw new UserValidationException("Some of the passed parameters are empty!");

            if (db.Projects[int.Parse(prms[0])].Users.Any() && db.Projects[int.Parse(prms[0])].Users.Any(x => x.UN == prms[1]))
                throw new UserValidationException("A user with that username already exists!");

            db.Projects[int.Parse(prms[0])].Users.Add(zavoda.CreateUser(prms[1], prms[2]));

            return "Successfully created a new user!";
        }
    }
}
