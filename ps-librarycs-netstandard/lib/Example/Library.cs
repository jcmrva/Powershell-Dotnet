using System;
using static System.Console;

namespace Example
{
    public class Library
    {
        public static int RandomInt() => (new Random()).Next();

        public void WriteTuple()
        {
            var tuple = (A: "one", B: "two");
            WriteLine(tuple.A);
            WriteLine(tuple.B);
        }
    }
}
