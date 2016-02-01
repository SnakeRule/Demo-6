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
       char[] Temp_Firstname = new char[4];
       char[] Temp_Lastname = new char[6];

        Random namerand = new Random();
            int generated;
            Stopwatch timer = new Stopwatch();
            Names allnames = new Names();
            timer.Start();
            for (int u = 0; u != 10000; u++)
            {
                for (int i = 0; i != 4; i++)
                {
                    generated = namerand.Next(0, 25);
                    Temp_Firstname[i] = allnames.letters[generated];
                }
                for (int i = 0; i != 6; i++)
                {
                    generated = namerand.Next(0, 25);
                    Temp_Lastname[i] = allnames.letters[generated];
                }
                allnames.Firstname = new string(Temp_Firstname);
                allnames.Lastname = new string(Temp_Lastname);
                Names fullname = new Names { Firstname = new string(Temp_Firstname), Lastname = new string(Temp_Lastname) };
                allnames.Addname(fullname);
            }
            allnames.ShowNames();
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Stop();
        }
    }
}
