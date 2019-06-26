using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        class Song
        {
            public string TypeList { get; set; }

            public string SongName { get; set; }

            public string Time { get; set; }
        }

        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());

            var songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string duration = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.SongName = name;
                song.Time = duration;

                songs.Add(song);
            }

            string categoryToPrint = Console.ReadLine();

            List<Song> filteredSongs = songs.Where(s => s.TypeList == categoryToPrint).ToList();

            if (categoryToPrint != "all")
            {
                foreach (var song in filteredSongs)
                {
                    Console.WriteLine(song.SongName);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.SongName);
                }
            }
        }
    }
}
