using Bytes2you.Validation;
using ProjectManager.Commands;
using ProjectManager.Common;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Data;
using ProjectManager.Models;
using System;
using System.Text;

namespace ProjectManager
{
    class Engine
    {
        private FileLogger logger;
        private CmdCPU processor;

        public Engine(FileLogger logger, CmdCPU processor)
        {
            // validate clauses
            Guard.WhenArgument(logger, "Engine Logger provider").IsNull().Throw();

            Guard.WhenArgument(processor, "Engine Processor provider").IsNull().Throw();


            this.logger = logger;

            this.processor = processor;
        }

        public void Start()
        {
            for (;;)
            {
                // read from console
                var cls = Console.ReadLine();

                if (cls.ToLower() == "exit")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.processor.process(cls);
                    Console.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opps, something happened. :(");
                    this.logger.error(ex.Message);
                }
            }
        }
    }
}
