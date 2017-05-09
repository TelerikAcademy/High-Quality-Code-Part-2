using Moq;
using NUnit.Framework;
using ProjectManager.Commands.Creational;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;
using ProjectManager.Data.Factories;
using ProjectManager.Data.Models.Contracts;
using System.Collections.Generic;

namespace ProjectManager.Tests.Commands.Creational
{
    [TestFixture]
    public class CreateTaskCommand_Should
    {
        [Test]
        public void Execute_ShouldThrowUserValidationException_WhenPassedInvalidParametersCount()
        {
            var databaseMock = new Mock<IDatabase>();
            var factoryStub = new Mock<IModelsFactory>();

            var projectId = 0;
            var userId = 0;
            var taskName = "Pesho";

            var sut = new CreateTaskCommand(databaseMock.Object, factoryStub.Object);
            var parameters = new List<string>() { projectId.ToString(), userId.ToString(), taskName };

            Assert.Throws<UserValidationException>(() => sut.Execute(parameters));
        }

        [Test]
        public void Execute_ShouldThrowUserValidationException_WhenPassedInvalidParametersContent()
        {
            var databaseMock = new Mock<IDatabase>();
            var factoryStub = new Mock<IModelsFactory>();

            var sut = new CreateTaskCommand(databaseMock.Object, factoryStub.Object);
            var parameters = new List<string>() { string.Empty, string.Empty, string.Empty, string.Empty };

            Assert.Throws<UserValidationException>(() => sut.Execute(parameters));
        }

        [TestCase(0)]
        [TestCase(12)]
        public void Execute_ShouldInvokeProjectsPropertyIndexer_WhenPassedValidProjectId(int projectId)
        {
            var databaseMock = new Mock<IDatabase>();
            var factoryStub = new Mock<IModelsFactory>();

            var projectStub = new Mock<IProject>();
            var userStub = new Mock<IUser>();
            var taskStub = new Mock<ITask>();            

            var users = new List<IUser>() { userStub.Object };
            var tasks = new List<ITask>();

            projectStub.SetupGet(x => x.Users).Returns(users);
            projectStub.SetupGet(x => x.Tasks).Returns(tasks);
            
            var userId = 0;
            var taskName = "Pesho";
            var taskState = "Pending";

            databaseMock.SetupGet(x => x.Projects[projectId]).Returns(projectStub.Object);
            factoryStub.Setup(x => x.CreateTask(userStub.Object, taskName, taskState)).Returns(taskStub.Object);

            var sut = new CreateTaskCommand(databaseMock.Object, factoryStub.Object);
            var parameters = new List<string>() { projectId.ToString(), userId.ToString(), taskName, taskState };
            sut.Execute(parameters);

            databaseMock.Verify(x => x.Projects[projectId], Times.Once);
        }

        [TestCase(0)]
        [TestCase(12)]
        public void Execute_ShouldInvokeUsersPropertyIndexer_WhenPassedValidUserId(int userId)
        {
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<IModelsFactory>();

            var projectMock = new Mock<IProject>();
            var userStub = new Mock<IUser>();
            var taskStub = new Mock<ITask>();

            var users = new List<IUser>() { userStub.Object };
            var tasks = new List<ITask>();

            projectMock.SetupGet(x => x.Users).Returns(users);
            projectMock.SetupGet(x => x.Tasks).Returns(tasks);

            var projectId = 0;
            var taskName = "Pesho";
            var taskState = "Pending";

            projectMock.SetupGet(x => x.Users[userId]).Returns(userStub.Object);
            databaseStub.SetupGet(x => x.Projects[It.IsAny<int>()]).Returns(projectMock.Object);

            factoryStub.Setup(x => x.CreateTask(userStub.Object, taskName, taskState)).Returns(taskStub.Object);

            var sut = new CreateTaskCommand(databaseStub.Object, factoryStub.Object);
            var parameters = new List<string>() { projectId.ToString(), userId.ToString(), taskName, taskState };
            sut.Execute(parameters);

            projectMock.Verify(x => x.Users[userId], Times.Once);
        }

        [Test]
        public void Execute_ShouldCreateTaskWithExactPassedParameteres_WhenPassedValidParameters()
        {
            var databaseStub = new Mock<IDatabase>();
            var factoryMock = new Mock<IModelsFactory>();

            var projectStub = new Mock<IProject>();
            var userStub = new Mock<IUser>();
            var taskStub = new Mock<ITask>();

            var users = new List<IUser>() { userStub.Object };
            var tasks = new List<ITask>();

            projectStub.SetupGet(x => x.Users).Returns(users);
            projectStub.SetupGet(x => x.Tasks).Returns(tasks);

            var projectId = 0;
            var userId = 0;
            var taskName = "Pesho";
            var taskState = "Pending";

            projectStub.SetupGet(x => x.Users[It.IsAny<int>()]).Returns(userStub.Object);
            databaseStub.SetupGet(x => x.Projects[It.IsAny<int>()]).Returns(projectStub.Object);

            factoryMock.Setup(x => x.CreateTask(userStub.Object, taskName, taskState)).Returns(taskStub.Object);

            var sut = new CreateTaskCommand(databaseStub.Object, factoryMock.Object);
            var parameters = new List<string>() { projectId.ToString(), userId.ToString(), taskName, taskState };
            sut.Execute(parameters);

            factoryMock.Verify(x => x.CreateTask(userStub.Object, taskName, taskState), Times.Exactly(1));
        }

        [Test]
        public void Execute_ShouldAddCreatedTaskToProject_WhenPassedValidParameters()
        {
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<IModelsFactory>();

            var projectMock = new Mock<IProject>();
            var userStub = new Mock<IUser>();
            var taskStub = new Mock<ITask>();

            var users = new List<IUser>() { userStub.Object };
            var tasks = new List<ITask>();

            projectMock.SetupGet(x => x.Users).Returns(users);
            projectMock.SetupGet(x => x.Tasks).Returns(tasks);

            var projectId = 0;
            var userId = 0;
            var taskName = "Pesho";
            var taskState = "Pending";
            
            projectMock.SetupGet(x => x.Users[It.IsAny<int>()]).Returns(userStub.Object);
            databaseStub.SetupGet(x => x.Projects[It.IsAny<int>()]).Returns(projectMock.Object);

            factoryStub.Setup(x => x.CreateTask(userStub.Object, taskName, taskState)).Returns(taskStub.Object);

            var sut = new CreateTaskCommand(databaseStub.Object, factoryStub.Object);
            var parameters = new List<string>() { projectId.ToString(), userId.ToString(), taskName, taskState };
            sut.Execute(parameters);

            Assert.AreEqual(1, tasks.Count);
            Assert.That(tasks.Contains(taskStub.Object));
        }

        [Test]
        public void Execute_ShouldReturnAppropriateMessage_WhenPassedValidParameters()
        {
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<IModelsFactory>();

            var projectStub = new Mock<IProject>();
            var userStub = new Mock<IUser>();
            var taskStub = new Mock<ITask>();

            var users = new List<IUser>() { userStub.Object };
            var tasks = new List<ITask>();

            projectStub.SetupGet(x => x.Users).Returns(users);
            projectStub.SetupGet(x => x.Tasks).Returns(tasks);

            var projectId = 0;
            var userId = 0;
            var taskName = "Pesho";
            var taskState = "Pending";

            projectStub.SetupGet(x => x.Users[It.IsAny<int>()]).Returns(userStub.Object);
            databaseStub.SetupGet(x => x.Projects[It.IsAny<int>()]).Returns(projectStub.Object);

            factoryStub.Setup(x => x.CreateTask(userStub.Object, taskName, taskState)).Returns(taskStub.Object);

            var sut = new CreateTaskCommand(databaseStub.Object, factoryStub.Object);
            var parameters = new List<string>() { projectId.ToString(), userId.ToString(), taskName, taskState };

            var executionResult = sut.Execute(parameters);
            Assert.That(executionResult.Contains("Successfully created"));
        }
    }
}
