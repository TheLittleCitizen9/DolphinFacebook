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
            IDisplay display2 = new ConsoleDisplayer2();
            IDisplay display3 = new ConsoleDisplayer3();
            IFacebookClient facebookClient = facebookClientFactory.CreateClient(display);
            IFacebookClient facebookClient2 = facebookClientFactory.CreateClient(display2);
            IFacebookClient facebookClient3 = facebookClientFactory.CreateClient(display3);
            facebookClient2.Subscribe(facebookClient);
            facebookClient3.Subscribe(facebookClient);
            facebookClient.WriteNewWallPost("This is a post");
            facebookClient2.Unsubscribe(facebookClient);
            facebookClient.WriteNewWallPost("Hello");
        }
    }
}
