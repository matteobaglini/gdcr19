using System;
using Xunit;
using DeepEqual.Syntax;
using ApprovalTests;
using ApprovalTests.Reporters;

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
            var foo = new Foo { Bar = "test" };
            foo.ShouldDeepEqual(new Foo
            {
                Bar = "test"
            });
        }

        [Fact]
        [UseReporter(typeof(VsCodeReporter))]
        public void ApprovalWorks()
        {
            var foo = new Foo { Bar = "test" };
            Approvals.Verify(foo);
        }

        class Foo
        {
            public String Bar { get; set; }

            public override String ToString()=>
                $"Foo(Bar={Bar})";
        }
    }
}
