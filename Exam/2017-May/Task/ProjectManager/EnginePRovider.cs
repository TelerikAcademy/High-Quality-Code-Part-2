using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class EnginePRovider
    {
        public Engine eng;

        public EnginePRovider(Engine eng)
        {
            this.eng = eng;
        }

        public void Start()
        {
            eng.Start();
        }
    }
}
