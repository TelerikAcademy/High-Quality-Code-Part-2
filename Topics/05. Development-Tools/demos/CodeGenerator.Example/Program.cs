using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OnlineJudgeSystemEntities();
            var contests = db.Contests
                .OrderBy(x => x.StartTime)
                .ToList();

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Name} - {contest.StartTime}");
            }
        }
    }
}
