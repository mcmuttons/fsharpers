using System;
using NUnit.Framework;

namespace csharpstuff
{
    [TestFixture]
    public class Class1
    {
        public Action<int> PrintAction(int x)
        {
            return (y => Console.WriteLine(x + " " + y));
        }

        [Test]
        public void DoStuff()
        {
            PrintAction(5)(6);
        }
    }
}
