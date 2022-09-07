using System;
namespace tweetprj.tweet
{
    public class Tweet
    {
       private static int CURRENT_ID;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }
        public Tweet(string from,string to, string body, string tag)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id =CURRENT_ID.ToString();
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag, string id)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = id;
        }
        public override string ToString()
        {
            string s = From.PadRight(20) + To.PadRight(20) + Body.PadRight(40) + Tag;
            return s;
        }

        public static Tweet Parse(string line)
        {
            string[] parts = line.Split(new char[] { '\t' });
            string from = parts[0];
            string to = parts[1];
            string body = parts[2];
            string tag = parts[3];
            Tweet t =  new Tweet(from, to, body, tag, CURRENT_ID.ToString());
            CURRENT_ID++;
            return t;
        }
    }
}
