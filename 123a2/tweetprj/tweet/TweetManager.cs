using System;
using System.Collections.Generic;
using System.IO;
namespace tweetprj.tweet
{
    public class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME;
       

        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            FILENAME = "/123a2/tweetprj/Assignment_02_TweetFile.txt";
            try
            {
                using (StreamReader stream = new StreamReader(FILENAME))
                {
                    while (!stream.EndOfStream)
                    {
                        string line = stream.ReadLine();
                        Tweet tweet = Tweet.Parse(line);
                        if (tweet != null)
                            TWEETS.Add(tweet);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Initialize();
            }
        }
        public static void Initialize()
        {
            string l1 = "@zoe\t@nho\tCanada is amazing\t#Canada";
            string l2 = "@yuki\t@danny\tNew streetcar!\t#streetcar";
            string l3 = "@liz\t@day\tIphone 13 is released\t#apple";
            string l4 = "@mike\t@kris\tBeach!!!\t#beach";
            string l5 = "@katie\t@meow\tI love dogs better!\t#dog";

            Tweet twt1 = Tweet.Parse(l1);
            Tweet twt2 = Tweet.Parse(l2);
            Tweet twt3 = Tweet.Parse(l3);
            Tweet twt4 = Tweet.Parse(l4);
            Tweet twt5 = Tweet.Parse(l5);

            TWEETS = new List<Tweet>();
            TWEETS.Add(twt1);
            TWEETS.Add(twt2);
            TWEETS.Add(twt3);
            TWEETS.Add(twt4);
            TWEETS.Add(twt5);

        }
        public static void ShowAll()
        {
            string testing = "From".PadRight(20) + "To".PadRight(20) + "Body".PadRight(40) + "Tag";
            Console.WriteLine(testing);
            for (int i = 0; i < TWEETS.Count; i++)
            {
                Console.WriteLine(TWEETS[i].ToString());
            }
        }
        public static void ShowAll(string tag)
        {
            bool tagExists = false;
            string testing = "From".PadRight(20) + "To".PadRight(20) + "Body".PadRight(40) + "Tag";
            Console.WriteLine("\nBy tag : " + tag);
            Console.WriteLine(testing);
            for (int i = 0; i < TWEETS.Count; i++)
            {
                if (TWEETS[i].Tag.ToLower() == tag.ToLower())
                {
                    Console.WriteLine(TWEETS[i].ToString());
                    tagExists = true;
                }
            }
            if (tagExists == false)
            {
                Console.WriteLine("No Tweet exists for " + tag);
            }
        }
    }
    
}
