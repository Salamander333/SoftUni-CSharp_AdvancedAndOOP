using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Phrase
    {
        public string _Phrase { get; set; }

        public Phrase()
        {
            var phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            Random r = new Random();
            _Phrase = phrases[r.Next(0, phrases.Count)];
        }
    }

    class Event
    {
        public string _Event { get; set; }

        public Event()
        {
            var events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            Random r = new Random();
            _Event = events[r.Next(0, events.Count)];
        }
    }

    class Author
    {
        public string _Author { get; set; }

        public Author()
        {
            var authors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            Random r = new Random();
            _Author = authors[r.Next(0, authors.Count)];
        }
    }

    class City
    {
        public string _City { get; set; }

        public City()
        {
            var cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" };
            Random r = new Random();
            _City = cities[r.Next(0, cities.Count)];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int messageCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messageCount; i++)
            {
                var @phrase = new Phrase();
                var @event = new Event();
                var @author = new Author();
                var @city = new City();

                Console.WriteLine($"{@phrase._Phrase} {@event._Event} {@author._Author} - {@city._City}");
            }
        }
    }
}
