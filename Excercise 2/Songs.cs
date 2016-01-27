using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Songs
    {
        public string SongName { get; set; }
        public string Length { get; set; }

        public void ShowSongs()
        {
            Console.WriteLine(SongName + " " + Length);
        }
    }
}
