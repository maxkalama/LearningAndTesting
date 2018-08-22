using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    public class BoolNullTests
    {
        [Fact]
        public void NullIsCastedToFalseBool()
        {
            //Assert.False((bool)null); bool is not nullable!
        }
    }
}
