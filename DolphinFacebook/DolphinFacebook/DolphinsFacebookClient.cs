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
        public IDisplay Display;

        public DolphinsFacebookClient(IDisplay display)
        {
            Subscribers = new List<IFacebookClient>();
            Display = display;
        }

        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += Display.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= Display.DisplayWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            NewWallPost?.Invoke(wallPost);
        }
    }
}
