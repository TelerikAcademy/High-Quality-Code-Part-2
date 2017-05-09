using Bytes2you.Validation;
using ProjectManager.Common.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using System;
using System.Text;

namespace ProjectManager
{
    public class Engine
    {
        private IReader reader;
        private IWriter writer;
        private ILogger logger;
        private IProcessor processor;

        public Engine(IReader reader, IWriter writer, ILogger logger, IProcessor processor)
        {
            // Property substitution, no guard clasuses needed here
            this.Reader = reader ?? ConsoleReader.Instance;
            this.Writer = writer ?? ConsoleWriter.Instance;
            this.Logger = logger ?? FileLogger.Instance;
            this.Processor = processor ?? CommandProcessor.Instance;
        }

        public IReader Reader
        {
            get
            {
                return this.reader;
            }

            set
            {
                Guard.WhenArgument(value, "Engine Reader provider").IsNull().Throw();
                this.reader = value;
            }
        }

        public IWriter Writer
        {
            get
            {
                return this.writer;
            }

            set
            {
                Guard.WhenArgument(value, "Engine Writer provider").IsNull().Throw();
                this.writer = value;
            }
        }

        public ILogger Logger
        {
            get
            {
                return this.logger;
            }

            set
            {
                Guard.WhenArgument(value, "Engine Logger provider").IsNull().Throw();
                this.logger = value;
            }
        }

        public IProcessor Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                Guard.WhenArgument(value, "Engine Processor provider").IsNull().Throw();
                this.processor = value;
            }
        }

        public void Start()
        {
            var builder = new StringBuilder();

            for (;;)
            {
                var commandLine = this.reader.ReadLine();

                if (commandLine.ToLower() == "exit")
                {
                    this.writer.Write(builder.ToString());
                    this.writer.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.processor.ProcessCommand(commandLine);
                    builder.AppendLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    builder.AppendLine(ex.Message);
                }
                catch (Exception ex)
                {
                    builder.AppendLine("Opps, something happened. :(");
                    this.logger.Error(ex.Message);
                }
            }
        }
    }
}
