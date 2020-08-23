using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    public class ConsoleDisplayer : IDisplay
    {
        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine(wallPost);
        }
    }
}
