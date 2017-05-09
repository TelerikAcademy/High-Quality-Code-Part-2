using Moq;
using NUnit.Framework;
using SchoolSystem.Cli.Models;
using SchoolSystem.Cli.Models.Contracts;
using SchoolSystem.Cli.Models.Enums;

namespace SchoolSystem.Tests.Models
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Constructor_ShouldSetGradeProperty_WhenInitialized()
        {
            var expectedGrade = Grade.Fifth;
            var student = new Student("Pesho", "Peshov", expectedGrade);
            Assert.AreEqual(expectedGrade, student.Grade);
        }

        [Test]
        public void Constructor_ShouldSetInstanceToMarksCollectionProperty_WhenInitialized()
        {
            var student = new Student("Pesho", "Peshov", Grade.Fifth);
            Assert.AreNotEqual(null, student.Marks);

        }

        [Test]
        public void ListMarks_ShouldReturnErrorMessage_WhenStudentHasNoMarks()
        {
            var student = new Student("Pesho", "Peshov", Grade.Fifth);

            var executionResult = student.ListMarks()
                .ToLower();

            Assert.That(executionResult.Contains("no marks"));
        }

        [Test]
        public void ListMarks_ShouldListMarks_WhenStudentHasMarks()
        {
            var mark = new Mock<IMark>();
            mark.SetupGet(c => c.Subject).Returns(Subject.English);
            mark.SetupGet(c => c.Value).Returns(5);
            
            var student = new Student("Pesho", "Peshov", Grade.Fifth);
            student.Marks.Add(mark.Object);

            var executionResult = student.ListMarks()
                .ToLower();

            Assert.That(executionResult.Contains("has"));
            Assert.That(executionResult.Contains("marks"));
            Assert.That(executionResult.Contains("english"));
            Assert.That(executionResult.Contains("5"));
        }
    }
}
