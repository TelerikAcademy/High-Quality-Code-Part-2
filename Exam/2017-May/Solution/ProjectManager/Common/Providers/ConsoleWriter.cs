using ProjectManager.Common.Contracts;
using System;

namespace ProjectManager.Common.Providers
{
    public class ConsoleWriter : IWriter
    {
        private static ConsoleWriter instance;

        private ConsoleWriter()
        {
        }

        // Singleton design pattern
        public static IWriter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConsoleWriter();
                }

                return instance;
            }            
        }

        public void Write(object value)
        {
            Console.Write(value);
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}
