using Moq;
using NUnit.Framework;
using SchoolSystem.Cli.Core;
using SchoolSystem.Cli.Core.Commands.Contracts;
using SchoolSystem.Cli.Core.Contracts;
using SchoolSystem.Tests.Extensions;
using System;
using System.Linq;

namespace SchoolSystem.Tests.Core
{
    [TestFixture]
    public class EngineTests
    {
        /* Could also extract Database provider for Teachers and Students collections
           But it will become too complex for the purposes of this exam.
           That is why Teachers and Students are not testable. */

        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenReaderIsNotPassed()
        {
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            Assert.Throws<ArgumentNullException>(() => new Engine(null, writer.Object, parser.Object));
        }

        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenWriterIsNotPassed()
        {
            var reader = new Mock<IReader>();
            var parser = new Mock<IParser>();
            Assert.Throws<ArgumentNullException>(() => new Engine(reader.Object, null, parser.Object));
        }

        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenParserIsNotPassed()
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            Assert.Throws<ArgumentNullException>(() => new Engine(reader.Object, writer.Object, null));
        }

        [Test, Timeout(2500)]
        public void Start_ShouldNotFallIntoInfiniteLoop_WhenPassedValidTerminationCommand()
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            reader.Setup(c => c.ReadLine()).Returns(terminationCommand);

            engine.Start();
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        [TestCase("TeacherAddMark 0 0 3")]
        [TestCase("RemoveStudent 0")]
        [TestCase("RemoveTeacher 0")]
        public void Start_ShouldNotThrow_WhenPassedOneValidTerminationCommand(string command)
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            reader.SetupMany(c => c.ReadLine(), command, terminationCommand);

            Assert.DoesNotThrow(() => engine.Start());
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void Start_ShouldCallWriteLineOnce_WhenPassedOneValidCommandAndOneTerminationCommand(string command)
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            reader.SetupMany(c => c.ReadLine(), command, terminationCommand);

            engine.Start();
            
            writer.Verify(c => c.WriteLine(It.IsAny<string>()), Times.Once());
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void Start_ShouldCallParseCommandOnce_WhenPassedOneValidCommandAndOneTerminationCommand(string command)
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            reader.SetupMany(c => c.ReadLine(), command, terminationCommand);

            engine.Start();

            parser.Verify(c => c.ParseCommand(command), Times.Once());
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void Start_ShouldCallParseParametersOnce_WhenPassedOneValidCommandAndOneTerminationCommand(string command)
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            reader.SetupMany(c => c.ReadLine(), command, terminationCommand);

            engine.Start();

            parser.Verify(c => c.ParseParameters(command), Times.Once());
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void Start_ShouldExecuteTheProcessedCommandOnce_WhenPassedOneValidCommandAndOneTerminationCommand(string command)
        {
            var reader = new Mock<IReader>();
            var writer = new Mock<IWriter>();
            var parser = new Mock<IParser>();
            var cmd = new Mock<ICommand>();
            var engine = new Engine(reader.Object, writer.Object, parser.Object);

            var terminationCommand = "End";
            var commandParameters = command.Split(' ').ToList();
            commandParameters.RemoveAt(0);

            reader.SetupMany(c => c.ReadLine(), command, terminationCommand);
            parser.Setup(c => c.ParseCommand(command)).Returns(cmd.Object);
            parser.Setup(c => c.ParseParameters(command)).Returns(commandParameters);

            engine.Start();

            cmd.Verify(c => c.Execute(commandParameters), Times.Once());
        }
    }
}
