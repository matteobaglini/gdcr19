using System;
using Xunit;
using DeepEqual.Syntax;

namespace gol.tests
{
    public class TestTheTester
    {
        [Fact]
        public void ClassicWorks()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void DeepWorks()
        {
            var foo = new Foo{Bar = "test"};
            foo.ShouldDeepEqual(new Foo{
                Bar = "test"
            });
        }

        private class Foo{
            public String Bar { get; set; }
        }
    }
}
