using System;

namespace VersionАttribute
{
    //Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods.
         
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : System.Attribute
    {
        private int major;
        private int minor;

        //Holds a version in the format major.minor (e.g. 2.11).
        public VersionAttribute(int major, int minor)
	    {
            this.Major = major;
            this.Minor = minor;
            this.Version = String.Format("{0}.{1}", Major, Minor);
	    }

        public string Version { get; set; }

        private int Major
        {
            get { return this.major; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalig value for major index");
                }

                this.major = value;
            }
        }

        private int Minor
        {
            get { return this.minor; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalig value for minor index");
                }

                this.minor = value;
            }
        }

    }
}

/*

using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]

public class AuthorAttribute : System.Attribute
{
	public string Name { get; private set; }

	public AuthorAttribute(string name)
	{
		this.Name = name;
	}
}

[Author("Svetlin Nakov")]
[Author("Nikolay Kostov")]
[Author("Doncho Minkov")]
[Author("George Georgiev")]
class CustomAttributesDemo
{
    static void Main(string[] args)
    {
        Type type = typeof(CustomAttributesDemo);
        object[] allAttributes = type.GetCustomAttributes(false);

        foreach (AuthorAttribute authorAttribute in allAttributes)
        {
            Console.WriteLine("This class is written by {0}. ", authorAttribute.Name);
        }
    }
}


using System;
using System.Runtime.InteropServices;

class UsingAttributes
{
	[DllImport("user32.dll", EntryPoint = "MessageBox")]
	public static extern int ShowMessageBox(int hWnd,
		string text, string caption, int type);

	static void Main()
	{
		ShowMessageBox(0, "Some text", "Some caption", 0);
	}
}


*/