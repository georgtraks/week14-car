using System;
using System.IO;

namespace movies
{
    class Program
    {
        class movie 
        {
            public string title;
            public string rating;
            public string year;


            public movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

        }
        static void Main(string[] args)
        {
            foreach (string movie in getdatafromfile())
            {
                string[] temparray = movie.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                movie newmovie = new movie(temparray[0], temparray[1], temparray[2]);
                Console.WriteLine($"title: {newmovie.title}, rating:{newmovie.rating}, year:{newmovie.year}");
            }

        }
        public static string[] getdatafromfile()
        {
            string filepath = @"C:\Users\opilane\samples\movies.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            return datafromfile;
        }

        public static void displayarrayelements(string[] somearray)
        {
            foreach(string element in somearray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
