using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;

namespace DolphinFacebook
{
    public class DolphinsFacebookClient : IFacebookClient, IDisplay
    {
        public List<IFacebookClient> Subscribers;
        public event Action<string> NewWallPost;

        public DolphinsFacebookClient()
        {
            Subscribers = new List<IFacebookClient>();
        }

        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine(wallPost);
        }

        public void Subscribe(IFacebookClient publisher)
        {
            NewWallPost += publisher.WriteNewWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            NewWallPost -= publisher.WriteNewWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            foreach (var subscriber in Subscribers)
            {
                NewWallPost.Invoke(wallPost);
            }
        }
    }
}
