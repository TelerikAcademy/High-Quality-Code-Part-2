using NUnit.Framework;
using SchoolSystem.Cli.Models;
using SchoolSystem.Cli.Models.Enums;
using System;

namespace SchoolSystem.Tests.Models
{
    [TestFixture]
    public class MarkTests
    {
        [TestCase(2f)]
        [TestCase(6f)]
        [TestCase(3.5f)]
        [TestCase(4.75f)]
        public void Value_ShouldNotThrow_WhenPassedValueIsInValidRange(float value)
        {
            Assert.DoesNotThrow(() => new Mark(Subject.Bulgarian, value));
        }

        [TestCase(1.5f)]
        [TestCase(11f)]
        [TestCase(-43f)]
        public void Value_ShouldThrowArgumentOutOfRangeException_WhenPassedValueIsNotInValidRange(float value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Mark(Subject.Bulgarian, value));
        }
    }
}
