using ProjectManager.Commands;
using ProjectManager.Common;


using ProjectManager.Common.Providers;

namespace ProjectManager
{
    using ProjectManager.Data;
    using ProjectManager.Models;

    public class Startup
    {
        public static void Main()
        {
            var eng = new Engine(new FileLogger(),
                new CmdCPU(
                    new CmdsFactory(
                        new Database(),
                        new ModelsFactory())));

            var provider = new EnginePRovider(eng);
            provider.Start();
        }
    }
}
