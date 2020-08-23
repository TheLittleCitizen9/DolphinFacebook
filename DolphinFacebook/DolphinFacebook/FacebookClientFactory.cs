using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    public class FacebookClientFactory : IFacebookClientFactory
    {
        public IFacebookClient CreateClient(IDisplay display)
        {
            IFacebookClient facebookClient = new DolphinsFacebookClient();
            facebookClient.NewWallPost += display.DisplayWallPost;
            return facebookClient;
        }
    }
}
