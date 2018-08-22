using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    public class DynamicKeywordTests
    {
        class MyClass
        {
            public Guid Id { get; set; }
            public int Count { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void Dynamic()
        {
            dynamic member = new MyClass();
            member.Id = new Guid();
            member.Name = "some name";
            member.Count = 3;

            Assert.Equal("some name", member.Name);
            Assert.ThrowsAny<Exception>(() => member.Count = "count");
        }
    }
}
