using MamaFacebook.Abstract;
using System;

namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookClientFactory facebookClientFactory = new FacebookClientFactory();
            IDisplay display = new ConsoleDisplayer();
            IFacebookClient facebookClient = facebookClientFactory.CreateClient(display);
            IFacebookClient facebookClient2 = facebookClientFactory.CreateClient(display);
            facebookClient.Subscribe(facebookClient2);
            facebookClient.WriteNewWallPost("This is a post");
        }
    }
}
