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

    public class ConsoleDisplayer2 : IDisplay
    {
        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine($"{wallPost}, 2");
        }
    }

    public class ConsoleDisplayer3 : IDisplay
    {
        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine($"{wallPost}, 3");
        }
    }
}
