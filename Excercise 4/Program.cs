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
            // Creating Stopwatch object timer
            Stopwatch timer = new Stopwatch();

            // Creating objects for the List testing
            Names allnames = new Names();
            Name name = new Name();
            timer.Start();
            name.GenerateName(allnames); // Generating 10 000 names and adding them to list
            allnames.ShowNames(); // Printing out the names
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Stop();
            timer.Reset();


            NameD nameD = new NameD();
            NamesD namesD = new NamesD();
            timer.Start();
            nameD.GenerateName(namesD);
            namesD.ShowNames();
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Stop();

        }
    }
}
