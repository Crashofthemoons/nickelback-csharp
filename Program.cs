using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {

            List<(string artist, string song)> goodSongs = new List<(string, string)>();
            HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>()
            {
                ("Chaka Khan", "I Feel for You"),
                ("Midnight Star", "Freak-a-Zoid"),
                ("Average White Band", "Pick Up the Pieces"),
                ("Mark Morrison", "Return of the Mack"),
                ("The Gap Band", "You Dropped a Bomb on Me"),
                ("Nickelback", "Photograph"),
                ("Nickelback", "Something in Your Mouth"),
            };

            foreach (var song in allSongs)
            {
                if( song.artist != "Nickelback") {
                    goodSongs.Add(song);
                }
            }
            foreach (var songs in goodSongs)
            {
                Console.WriteLine($"{songs.artist}: {songs.song}");
            }
        }
    }
}
