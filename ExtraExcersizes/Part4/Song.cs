using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExcersizes.Part4
{
    internal class Song
    {
        //Fields
        private string artistName;
        private string title;
        private TimeSpan time;

        //Propertys
        public string ArtistName { get { return artistName; } set {
                if (value.Length < 3 || value.Length > 20)
                    throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
                artistName = value; 
            } }
        public string Title { get { return title; } set {
                if (value.Length < 3 || value.Length > 30)
                    throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
                title = value; 
            } }
        public string Time { get { return time.ToString(); } set { 
                string[] times = value.Split(':');
                if (times.Length == 2)
                {
                    if(int.TryParse(times[0], out int minutes))
                    {
                        if (minutes < 0 || minutes > 14)
                            throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                        else
                        {
                            if(int.TryParse(times[1], out int seconds))
                            {
                                if (seconds < 0 || seconds > 59)
                                    throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                                else
                                {
                                    time = new TimeSpan(0, minutes, seconds);
                                }
                            }
                        }
                    }
                }
                else
                {
                    throw new InvalidSongLengthException("Invalid song length");
                }
            } }

        //Constructors
        public Song(string name, string title, string length)
        {
            ArtistName = name;
            Title = title;
            Time = length;
            Console.WriteLine("Song added");
        }

        //Public Methods


        //Private Methods


        //Destructors


    }
}
