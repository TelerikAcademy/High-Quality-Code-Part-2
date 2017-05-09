using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using System;

namespace ProjectManager.Models
{
    public class ModelsFactory
    {
        
        public Project CreateProject(string name, string startingDate, string endingDate, string state)
        {
            DateTime starting;
            DateTime end;
            var startingDateSuccessful = DateTime.TryParse(startingDate, out starting);
            var endingDateSuccessful = DateTime.TryParse(endingDate, out end);
            if (!startingDateSuccessful)
                throw new UserValidationException("Failed to parse the passed starting date!");

            if (!endingDateSuccessful)
                throw new UserValidationException("Failed to parse the passed ending date!");

            var pj = new Project(name, starting, end, state);
            validator.Validate(pj);

            return pj;
        }

        public Task CreateTask(User owner, string name, string state)
        {
            var task = new Task(name, owner, state);
            validator.Validate(task);

            return task;
        }

        private readonly Validator validator = new Validator();

        public User CreateUser(string username, string email)
        {
            var user = new User(email, username);
            validator.Validate(user);

            return user;
        }       
    }
}
