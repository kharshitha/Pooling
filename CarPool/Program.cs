using System;
using System.IO;

namespace CarPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup startupObj = new Startup();
            UserInterface userInterfaceObj = new UserInterface();
            UserInterface.Start(Startup.PoolObj);
       }
    }
}
