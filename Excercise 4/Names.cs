using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Names
    {

        Random namerand = new Random();
        public List<Name> names;

        public Names()
        {
            names = new List<Name>();
        }

        public void Addname(Name name)
        {
            names.Add(name);
        }

        public void ShowNames()
        {
            foreach(Name fullname in names)
            {
                Console.WriteLine(fullname.Firstname + " " + fullname.Lastname);
            }
        }
    }
}
