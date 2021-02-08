using ConfigurationPosteDevCSHARP.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string mdu = DateBaseHelper.Mdu();

            Assert.Equal("Ceci est un test", mdu);

            //int a = 5;
            //int b = 10;

            //Assert.Equal(15, a + b);
        }
    }
}
