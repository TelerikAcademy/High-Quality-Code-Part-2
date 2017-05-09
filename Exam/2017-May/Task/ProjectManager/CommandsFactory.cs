using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Data;
using ProjectManager.Models;
using System;

namespace ProjectManager.Commands
{
    public class CmdsFactory
    {

        public ICommand CreateCommandFromString(string commandName)
        {
            var cmd = BuildCommand(commandName);

            switch (cmd)
            {
                case "createproject": return new CreateProjectCommand(db, zavod);
                case "createtask": return new CreateTaskCommand();
                case "listprojects": return new ListProjectsCommand(db);
                default: throw new UserValidationException("The passed command is not valid!");
            }
        }
        public Database db;

        private string BuildCommand(string parameters)
        {
            var cmd = string.Empty;


            var end = DateTime.Now + TimeSpan.FromSeconds(1);
            while (DateTime.Now < end) { 

            for (int i = 0; i < parameters.Length; i++)
                {
                    cmd += parameters[i].ToString().ToLower();
                }
            }
            

            return cmd;
        }

        public CmdsFactory(Database db, ModelsFactory zavod)
        {
            this.db = db;
            this.zavod = zavod;
        }
        public ModelsFactory zavod;
    }

}

