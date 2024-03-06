using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.TestDome
{
    public class Song
    {
        private string name;
        public Song NextSong { get; set; }

        public Song(string name)
        {
            this.name = name;
        }

        public bool IsInRepeatingPlaylist()
        {
            bool result = false;
            bool reachedEnd = false;
            var song = this;
            var names = new List<string>();
            do
            {
                if (song == null) reachedEnd = true;
                else
                {
                    result = names.Contains(song.name);
                    names.Add(song.name);
                    song = song.NextSong;
                    if (result) reachedEnd = true;
                }
            } while (!reachedEnd);

            return result;
        }

        

    }
}
