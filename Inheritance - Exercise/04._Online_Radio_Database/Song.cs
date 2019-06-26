using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database
{
    class Song
    {
        private string artistName;
        private string songName;
        private int songMinutes;
        private int songSeconds;
        
        public Song(string artistName, string songName, int songMinutes, int songSeconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongMinutes = songMinutes;
            this.SongSeconds = songSeconds;
        }

        public string ArtistName
        {
            get => this.artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20 )
                {
                    throw new InvalidArtistNameException();
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        public int SongMinutes
        {
            get => this.songMinutes;
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                this.songMinutes = value;
            }
        }

        public int SongSeconds
        {
            get => this.songSeconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.songSeconds = value;
            }
        }

    }
}
