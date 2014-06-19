namespace VersionАttribute
{
    using System;

    class ProgramMain
    {
        public static void Main()
        {
            //Test for Version of class
            Type typeClass = typeof(ClassToTest);
            object[] allAttributesOfClass = typeClass.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributesOfClass)
            {
                Console.WriteLine("This class version is: {0}. ", attribute.Version);
            }

            Console.WriteLine();

            //Test for Version of struction
            Type typeStruct = typeof(StructToTest);
            object[] allAttributesOfStruct = typeStruct.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributesOfStruct)
            {
                Console.WriteLine("This structure version is: {0}. ", attribute.Version);
            }
        }
    }
}
