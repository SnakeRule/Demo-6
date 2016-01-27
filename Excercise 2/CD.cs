using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class CD
    {
        public string CdName { get; set; }
        public string Artist { get; set; }

        public List<Songs> songs;

        public CD()
        {
            songs = new List<Songs>();
        }

        public void AddSong(Songs song)
        {
            songs.Add(song);
        }

        public void PrintData()
        {
            Console.WriteLine("Artist: " + Artist + "\nCD title: " + CdName + "\n\n");
            foreach (Songs song in songs)
            {
                Console.WriteLine(song.SongName + " " + song.Length + "\n");
            }
        }
    }
}
