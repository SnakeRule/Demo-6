using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Stopwatch timer = new Stopwatch();
            Names allnames = new Names();
            Name name = new Name();
            timer.Start();
            name.GenerateName(allnames);
            allnames.ShowNames();
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Stop();
        }
    }
}
