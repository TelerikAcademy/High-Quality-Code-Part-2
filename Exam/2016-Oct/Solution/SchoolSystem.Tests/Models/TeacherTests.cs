using Moq;
using NUnit.Framework;
using SchoolSystem.Cli.Models;
using SchoolSystem.Cli.Models.Contracts;
using SchoolSystem.Cli.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Tests.Models
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void Constructor_ShouldSetSubjectProperty_WhenInitialized()
        {
            var expectedSubject = Subject.Bulgarian;
            var teacher = new Teacher("Pesho", "Peshov", expectedSubject);
            Assert.AreEqual(expectedSubject, teacher.Subject);
        }

        [TestCase("P", "Goshev")]
        [TestCase("Pesho", "G")]
        [TestCase("PeshoPeshoPeshoPeshoPeshoPeshoPesho", "Goshev")]
        [TestCase("Pesho", "GoshevGoshevGoshevGoshevGoshevGoshevGoshev")]
        [TestCase("123", "Goshev")]
        [TestCase("Pesho", "123")]
        public void Constructor_ShouldThrowArgumentException_WhenPassedFirstOrLastNameIsInvalid(string firstName, string lastName)
        {
            Assert.Throws<ArgumentException>(() => new Teacher(firstName, lastName, Subject.Bulgarian));
        }

        [Test]
        public void AddMark_ShouldAddMarkToThePassedStudent_WhenPassedMarkIsValid()
        {
            var expectedSubject = Subject.Bulgarian;
            var expectedValue = 5;

            var student = new Mock<IStudent>();
            var teacher = new Teacher("Pesho", "Peshov", expectedSubject);

            student.Setup(c => c.Marks)
                .Returns(new List<IMark>());

            teacher.AddMark(student.Object, expectedValue);

            Assert.AreEqual(expectedSubject, student.Object.Marks.Single().Subject);
            Assert.AreEqual(expectedValue, student.Object.Marks.Single().Value);
        }

        [Test]
        public void AddMark_ShouldThrowArgumentException_WhenAddingMoreThan20Marks()
        {
            var student = new Mock<IStudent>();
            var teacher = new Teacher("Pesho", "Peshov", Subject.Bulgarian);
            var mark = new Mock<IMark>();

            var listOfMarks = Enumerable.Repeat(mark.Object, 20)
                    .ToList();

            student.Setup(c => c.Marks)
                .Returns(listOfMarks);

            Assert.Throws<ArgumentException>(() => teacher.AddMark(student.Object, 5));
        }
    }
}
