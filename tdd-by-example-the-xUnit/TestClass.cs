using System;

namespace tdd_by_example_the_xUnit
{
    public class TestClass
    {
        private bool wasRun;

        public TestClass(string name)
        {
            wasRun = false;
        }

        private void TestMethod()
        {
            wasRun = true;
        }

        public bool WasRun()
        {
            return wasRun;
        }

        public void Run()
        {
            TestMethod();
        }
    }
}