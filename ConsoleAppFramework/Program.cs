namespace ConsoleAppFramework
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //var core = new LibraryCore.Class1().GetVersion();
            //var coreInner = string.Join(", ", new LibraryCore.Class1().GetInnerVersion());
            var framework = new LibraryFramework.Class1().GetVersion();
            var frameworkInner = string.Join(", ", new LibraryFramework.Class1().GetInnerVersion());
            var standard = new LibraryStandard.Class1().GetVersion();
            var standardInner = string.Join(", ", new LibraryStandard.Class1().GetInnerVersion());
        }
    }
}
