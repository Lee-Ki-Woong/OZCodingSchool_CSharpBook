using System;

namespace OZCodingSchool_CSharpBook
{
    class VriableSameValue
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = b = c = 10;

            Console.WriteLine( "{0}, {1}, {2}", a, b, c);
        }
    }
}
