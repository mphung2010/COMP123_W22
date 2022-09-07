using System;
using System.Collections.Generic;
using System.IO;

namespace tweetprj.tweet
{
    class Program
    {
        static void Main(string[] args)
        {
            // `TweetManager.Initialize();
            TweetManager.ShowAll();
            Console.WriteLine("=============================================");
            TweetManager.ShowAll("Raptors");
        }
    }
}
