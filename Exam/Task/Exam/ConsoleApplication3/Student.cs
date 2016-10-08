using ConsoleApplication3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System.Text;
    using System.Linq;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
        class Student        {
        // This code sucks, you know it and I know it.  
        // Move on and call me an idiot later.
        public string fNeim; public Grade grads; public List<Mark> mark; public string lNeim;
        Student(string _, string __, Grade ___) { fNeim = _; lNeim = __; grads = ___; mark = new List<Mark>(); }
        public string ListMarks() {
            var potatos = mark.Select(m => $"{m.subject} => {m.value}").ToList();
            return string.Join("\n", potatos); }
    }
}
