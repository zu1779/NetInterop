namespace LibraryCoreInner
{
    using System.Reflection;

    public class Class1
    {
        public string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }
    }
}
