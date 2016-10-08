using System;
using SchoolSystem.Cli.Core.Contracts;

namespace SchoolSystem.Cli.Core.Providers
{
    public class ConsoleReaderProvider : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
