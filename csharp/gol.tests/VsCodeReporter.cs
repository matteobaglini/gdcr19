using ApprovalTests.Reporters;

namespace gol.tests
{
    public class VsCodeReporter : GenericDiffReporter
    {
        public static readonly VsCodeReporter INSTANCE = new VsCodeReporter();

        public VsCodeReporter() :
            base(new DiffInfo(@"C:\Users\matteo\scoop\shims\code.cmd",
                              "--diff {0} {1}",
                              DiffPrograms.TEXT_AND_IMAGE))
        {
        }
    }
}
