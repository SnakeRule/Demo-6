using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Names
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char[] letters = new char[25] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'W', 'X', 'Y', 'Z' }; 

        Random namerand = new Random();
        public List<Names> names;

        public Names()
        {
            names = new List<Names>();
        }

        public void Addname(Names fullname)
        {
            names.Add(fullname);
        }

        public void ShowNames()
        {
            foreach(Names fullname in names)
            {
                Console.WriteLine(fullname.Firstname + " " + fullname.Lastname);
            }
        }
    }
}
