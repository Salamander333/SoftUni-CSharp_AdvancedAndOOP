using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Online_Radio_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new List<Song>();

            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                try
                {
                    var songInput = Console.ReadLine().Split(";");
                    var artistName = songInput[0];
                    var songName = songInput[1];

                    var songLenght = songInput[2].Split(":");
                    var songMinutes = int.Parse(songLenght[0]);
                    var songSeconds = int.Parse(songLenght[1]);

                    var song = new Song(artistName, songName, songMinutes, songSeconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception message)
                {
                    Console.WriteLine(message.Message);
                }
            }
            

            Console.WriteLine($"Songs added: {songs.Count}");

            var seconds = songs.Sum(x => x.SongSeconds) / 60;
            var secondsToDisplay = songs.Sum(x => x.SongSeconds) % 60;
            var minutes = songs.Sum(x => x.SongMinutes) + seconds;
            var minutesToDisplay = (songs.Sum(x => x.SongMinutes) + seconds) % 60;
            var hourToDisplay = minutes / 60;

            Console.WriteLine($"Playlist length: {hourToDisplay}h {minutesToDisplay}m {secondsToDisplay}s");
        }
    }
}
