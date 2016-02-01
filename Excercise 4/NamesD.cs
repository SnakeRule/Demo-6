using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class NamesD
    {
        public Dictionary<int, NameD> namesD;

        public NamesD()
        {
            namesD = new Dictionary<int, NameD>();
        }

        public void Addname(NameD name, int u)
        {
            namesD.Add(u, name);
        }

        public void ShowNames()
        {
            for(int i = 0; i != 10000; i++)
            {
                Console.WriteLine(namesD[i].Firstname + " " + namesD[i].Lastname);
            }
        }

    }
}
