using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Name
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char[] letters = new char[25] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'W', 'X', 'Y', 'Z' };


        public void GenerateName(Names allnames)
        {
            int generated;
            Random namerand = new Random();
            char[] Temp_Firstname = new char[4];
            char[] Temp_Lastname = new char[6];

            for (int u = 0; u != 10000; u++)
            {
                for (int i = 0; i != 4; i++)
                {
                    generated = namerand.Next(0, 25);
                    Temp_Firstname[i] = letters[generated];
                }
                for (int i = 0; i != 6; i++)
                {
                    generated = namerand.Next(0, 25);
                    Temp_Lastname[i] = letters[generated];
                }
                Firstname = new string(Temp_Firstname);
                Lastname = new string(Temp_Lastname);
                Name fullname = new Name { Firstname = new string(Temp_Firstname), Lastname = new string(Temp_Lastname) };
                allnames.Addname(fullname);
            }
        }
    }
}
