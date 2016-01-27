using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {

            CD meliora = new CD { Artist = "Ghost", CdName = "Meliora" };

            Songs song1 = new Songs { SongName = "Spirit", Length = "5:15" };
            Songs song2 = new Songs { SongName = "From the Pinnacle to the Pit", Length = "4:02" };
            Songs song3 = new Songs { SongName = "Cirice", Length = "6:02"};
            Songs song4 = new Songs { SongName = "Spöksonat", Length = "0:56" };
            Songs song5 = new Songs { SongName = "He Is", Length = "4:13" };
            Songs song6 = new Songs { SongName = "Mummy Dust", Length = "4:07" };
            Songs song7 = new Songs { SongName = "Majesty", Length = "5:24" };
            Songs song8 = new Songs { SongName = "Devil Church", Length = "1:06" };
            Songs song9 = new Songs { SongName = "Absolution", Length = "4:50" };
            Songs song10 = new Songs { SongName = "Deus In Absentia", Length = "5:37" };


            meliora.AddSong(song1);
            meliora.AddSong(song2);
            meliora.AddSong(song3);
            meliora.AddSong(song4);
            meliora.AddSong(song5);
            meliora.AddSong(song6);
            meliora.AddSong(song7);
            meliora.AddSong(song8);
            meliora.AddSong(song9);
            meliora.AddSong(song10);


            meliora.PrintData();
        }
    }
}
