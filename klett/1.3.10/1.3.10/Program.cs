using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._10
{
    class Song
    {
        public string title, singer;

        public Song()
        {
            title = "unknown";
            singer = "unknown";
        }
        public Song(string title)
        {
            this.title = title;
            singer = "unknown";
        }
        public Song(string title, string singer)
        {
            this.title = title;
            this.singer = singer;
        }
        public Song(Song song)
        {
            title = song.title;
            singer = song.title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests = new int[4];
            Song song;
            for(int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        song = new Song();
                        tests[i] = song.title == "unknown" && song.singer == "unknown" ? 1 : 0;
                        break;

                    case 1:
                        song = new Song("a");
                        tests[i] = song.title == "a" && song.singer == "unknown" ? 1 : 0;
                        break;

                    case 2:
                        song = new Song("a", "b");
                        tests[i] = song.title == "a" && song.singer == "b" ? 1 : 0;
                        break;

                    case 3:
                        song = new Song();
                        Song song1 = new Song(song);
                        tests[i] = song.title == song1.title && song.singer == song1.singer ? 1 : 0;
                        break;
                }
            }
            int j = 1;
            foreach(int test in tests)
                Console.WriteLine($"Test{j++}: {test}");
        }
    }
}
