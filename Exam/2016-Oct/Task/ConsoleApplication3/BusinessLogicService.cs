using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{



    // I am not sure if we need this, but too scared to delete. 
    class BusinessLogicService
    {
        public void Execute(ConsoleReaderProvider padhana)
        {
            var injan = new Engine(padhana);
            injan.BrumBrum();
        }
    }
}
