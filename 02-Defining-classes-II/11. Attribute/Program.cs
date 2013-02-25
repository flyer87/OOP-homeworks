/*
 * - Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
 *   and holds a version in the format major.minor (e.g. 2.11). 
 *   Apply the version attribute to a sample class and display its version at runtime
 */

using System;

[Version(5, 18)]
class Program
{
    static void Main(string[] args)
    {
        // Get Version of class "Program "
        Type type = typeof(Program);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute attribute in allAttributes)
        {
            Console.WriteLine("Version: {0}.{1}", attribute.Major, attribute.Minor);
        }

        // Get version of struct: TestStruct
        type = typeof(TestStruct);
        object[] customAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute attr in customAttributes)
        {
            Console.WriteLine("version: {0}.{1}", attr.Major, attr.Minor);
        }
    }
}

[Version(7, 11)]
struct TestStruct
{
    // empty body
}