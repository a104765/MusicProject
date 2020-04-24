using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace MusicProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            

            

            Console.ReadKey();
        }

        public static void songPlayer() {
            Player P = new Player();
            string path = @"F:\MyStuff\MusicProgram\MusicProgram\Music";
            var rand = new Random();

            List<string> AllMusic = new List<string>();
            List<string> Played = new List<string>();
            foreach (string i in Directory.GetFiles(path, "*.m4a"))
            {
                AllMusic.Add(i);
            }
            while (AllMusic.Count != 0)
            {
                int num = rand.Next(AllMusic.Count);
                string lastPlayed;

                if (!Played.Contains(AllMusic[num]))
                {

                    P.Play(AllMusic[num]);
                    Played.Add(AllMusic[num]);
                    AllMusic.RemoveAt(num);
                }
                else
                {
                    Console.WriteLine("End");
                }

                if (AllMusic.Count == 1)
                {
                    lastPlayed = Played[Played.Count - 1];
                    foreach (string i in Played)
                    {
                        AllMusic.Add(i);
                    }
                    Played.Clear();
                    AllMusic.Remove(lastPlayed);
                    Played.Add(lastPlayed);

                }

            }
        }

        public static void Timer() 
        {
            bool a = true;

            while (a == true)
            {
                DateTime dt = DateTime.Now;
                if (dt.Hour == 17 && dt.Minute == 43 && dt.Second == 1)
                {
                    Console.WriteLine("6:10");
                    Timer();
                }
                else if (dt.Hour == 18 && dt.Minute == 12 && dt.Second == 1)
                {
                    Console.WriteLine("6:12");
                    Timer();
                }
                else { }

            }
        }

    }
}
