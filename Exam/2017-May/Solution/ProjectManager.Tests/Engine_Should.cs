using Moq;
using NUnit.Framework;
using ProjectManager.Common.Contracts;
using ProjectManager.Common.Exceptions;
using System;

namespace ProjectManager.Tests
{
    [TestFixture]
    public class Engine_Should
    {
        [Test]
        public void Ctor_ShouldNotThrow_WhenPassedNullValues()
        {
            Assert.DoesNotThrow(() => new Engine(null, null, null, null));
        }

        [Test]
        public void Ctor_ShouldAssignDefaultProviders_WhenPassedNullValues()
        {
            var sut = new Engine(null, null, null, null);

            Assert.IsNotNull(sut.Reader);
            Assert.IsNotNull(sut.Writer);
            Assert.IsNotNull(sut.Logger);
            Assert.IsNotNull(sut.Processor);
        }

        [Test]
        public void Reader_ShouldThrow_WhenPassedNullValue()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerStub.Object, processorStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Reader = null);
        }

        [Test]
        public void Writer_ShouldThrow_WhenPassedNullValue()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerStub.Object, processorStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Writer = null);
        }

        [Test]
        public void Logger_ShouldThrow_WhenPassedNullValue()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerStub.Object, processorStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Logger = null);
        }

        [Test]
        public void Processor_ShouldThrow_WhenPassedNullValue()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerStub.Object, processorStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Processor = null);
        }

        [Test]
        public void Start_ShouldReadLineFromReaderProvider_WhenInvoked()
        {
            var readerMock = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            readerMock.Setup(x => x.ReadLine())
                .Returns("Exit");

            var sut = new Engine(readerMock.Object, writerStub.Object, loggerStub.Object, processorStub.Object);
            sut.Start();

            readerMock.Verify(x => x.ReadLine(), Times.Exactly(1));
        }

        [Test]
        public void Start_ShouldWriteLineToWriterProvider_WhenPassedTerminationCommand()
        {
            var readerStub = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            readerStub.Setup(x => x.ReadLine())
                .Returns("Exit");

            var sut = new Engine(readerStub.Object, writerMock.Object, loggerStub.Object, processorStub.Object);
            sut.Start();

            writerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void Start_ShouldNotThrow_WhenInvokedAndValidationExceptionRises()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            readerStub.SetupSequence(x => x.ReadLine())
                .Returns(string.Empty)
                .Returns("Exit");
            
            processorStub.Setup(x => x.ProcessCommand(It.IsAny<string>()))
                .Throws(new UserValidationException(string.Empty));

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerStub.Object, processorStub.Object);
            Assert.DoesNotThrow(() => sut.Start());
        }

        [Test]
        public void Start_ShouldExceptionErrorMessage_WhenInvokedAndValidationExceptionRises()
        {
            var readerStub = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            var exceptionMessage = "Pesho";

            readerStub.SetupSequence(x => x.ReadLine())
                .Returns(string.Empty)
                .Returns("Exit");

            processorStub.Setup(x => x.ProcessCommand(It.IsAny<string>()))
                .Throws(new UserValidationException(exceptionMessage));

            var sut = new Engine(readerStub.Object, writerMock.Object, loggerStub.Object, processorStub.Object);
            sut.Start();

            writerMock.Verify(x => x.Write(It.Is<string>(y => y.Contains(exceptionMessage))), Times.Exactly(1));
        }

        [Test]
        public void Start_ShouldNotThrow_WhenInvokedAndGenericExceptionRises()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            readerStub.SetupSequence(x => x.ReadLine())
                .Returns(string.Empty)
                .Returns("Exit");

            processorStub.Setup(x => x.ProcessCommand(It.IsAny<string>()))
                .Throws(new Exception());

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerStub.Object, processorStub.Object);
            Assert.DoesNotThrow(() => sut.Start());
        }

        [Test]
        public void Start_ShouldWriteGenericErrorMessage_WhenInvokedAndGenericExceptionRises()
        {
            var readerStub = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var loggerStub = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            readerStub.SetupSequence(x => x.ReadLine())
                .Returns(string.Empty)
                .Returns("Exit");

            processorStub.Setup(x => x.ProcessCommand(It.IsAny<string>()))
                .Throws(new Exception());

            var sut = new Engine(readerStub.Object, writerMock.Object, loggerStub.Object, processorStub.Object);
            sut.Start();

            writerMock.Verify(x => x.Write(It.Is<string>(y => y.Contains("something happened"))), Times.Exactly(1));
        }

        [Test]
        public void Start_ShouldLogExceptionMessage_WhenInvokedAndGenericExceptionRises()
        {
            var readerStub = new Mock<IReader>();
            var writerStub = new Mock<IWriter>();
            var loggerMock = new Mock<ILogger>();
            var processorStub = new Mock<IProcessor>();

            var exceptionMessage = "Pesho";

            readerStub.SetupSequence(x => x.ReadLine())
                .Returns(string.Empty)
                .Returns("Exit");

            processorStub.Setup(x => x.ProcessCommand(It.IsAny<string>()))
                .Throws(new Exception(exceptionMessage));

            var sut = new Engine(readerStub.Object, writerStub.Object, loggerMock.Object, processorStub.Object);
            sut.Start();

            loggerMock.Verify(x => x.Error(exceptionMessage), Times.Exactly(1));
        }        
    }
}
