using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    public class DevideIntGetDecimal
    {
        [Fact]
        public void GetDecimalDivideInts()
        {
            var d = 10m;
            int req = 1000;
            decimal res = req / 100;
            Assert.Equal(d,res);
        }
    }
}
