namespace LibraryCore
{
    using System.Collections.Generic;
    using System.Reflection;

    public class Class1
    {
        public string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }
        public List<string> GetInnerVersion()
        {
            return new List<string>
            {
                new LibraryCoreInner.Class1().GetVersion(),
                new LibraryFrameworkInner.Class1().GetVersion(),
                new LibraryStandardInner.Class1().GetVersion(),
            };
        }
    }
}
