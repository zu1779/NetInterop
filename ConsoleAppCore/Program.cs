namespace ConsoleAppCore
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string version;
            version = new LibraryCore.Class1().GetVersion();
            version = new LibraryFramework.Class1().GetVersion();
            version = new LibraryStandard.Class1().GetVersion();
        }
    }
}
