using System;
using ProjectManager.Common.Contracts;

namespace ProjectManager.Common.Providers
{
    public class ConsoleReader : IReader
    {
        private static ConsoleReader instance;

        private ConsoleReader()
        {
        }

        // Singleton design pattern
        public static IReader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConsoleReader();
                }

                return instance;
            }
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
