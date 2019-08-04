using System;

namespace Glued.UnitTests
{
    public class TestException : Exception
    {
        public TestException() {}
        public TestException(string message): base(message) {}
    }
}