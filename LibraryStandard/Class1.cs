namespace LibraryStandard
{
    using System.Collections.Generic;

    public class Class1
    {
        public string GetVersion()
        {
            return "ClassStandard";
        }
        public List<string> GetInnerVersion()
        {
            return new List<string>
            {
                //new LibraryCoreInner.Class1().GetVersion(),
                new LibraryFrameworkInner.Class1().GetVersion(),
                new LibraryStandardInner.Class1().GetVersion(),
            };
        }
    }
}
