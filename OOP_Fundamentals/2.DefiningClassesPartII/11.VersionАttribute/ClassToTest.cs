namespace VersionАttribute
{
    //Apply the version attribute to a sample class and display its version at runtime.

    [Version(1,0)]
    public class ClassToTest
    {
        [Version(2,3)]
        public void  Method()
        {
            //Some code...
        }

        //Some code...
    }
}
