using H.Necessaire;
using H.Necessaire.Runtime.CLI.Commands;

namespace H.Necessaire.Versioning.Cli.Commands
{
    internal class DebugCommand : CommandBase
    {
        public override Task<OperationResult> Run()
        {
            Version? version = Version.Self.GetCurrent();

            return OperationResult.Win().AsTask();
        }
    }
}
