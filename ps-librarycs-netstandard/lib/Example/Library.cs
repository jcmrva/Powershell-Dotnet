using System;

namespace Example
{
    public class Library
    {
        public static int RandomInt() => (new Random()).Next();

        public void WriteTuple()
        {
            var tuple = (A: "one", B: "two");
            Console.WriteLine(tuple.A);
            Console.WriteLine(tuple.B);
        }
    }
}
