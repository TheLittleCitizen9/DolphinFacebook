using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;

namespace DolphinFacebook
{
    public class DolphinsFacebookClient : IFacebookClient
    {
        public List<IFacebookClient> Subscribers;
        public event Action<string> NewWallPost;

        public DolphinsFacebookClient()
        {
            Subscribers = new List<IFacebookClient>();
        }

        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += WriteNewWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= WriteNewWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            NewWallPost?.Invoke(wallPost);
        }
    }
}
