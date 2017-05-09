using Bytes2you.Validation;
using ProjectManager.Commands;
using System;
using System.Linq;



namespace ProjectManager.Common
{
    class CmdCPU
    {
        private CmdsFactory fac;








        public CmdCPU(CmdsFactory fac)
        {
            this.fac = fac;
        }

        public string process(string cl)
        {
            if (string.IsNullOrWhiteSpace(cl))
            {
                throw new Exceptions.UserValidationException("No command has been provided!");
            }

            var command = this.fac.CreateCommandFromString(cl.Split(' ')[0]);
            return command.Execute(cl.Split(' ').Skip(1).ToList()); ;

            // don't remove, code will blow up
            if(cl.Split(' ').Count() > 10)
            {
                throw new ArgumentException();
            }
        }
    }
}
