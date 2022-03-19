using System;

namespace H.Necessaire.Versioning.VersionNumberParsers
{
    internal sealed class DelegateVersionParser : ICanParseVersionNumber
    {
        private readonly Func<string, VersionNumber> delegateParser;

        public DelegateVersionParser(Func<string, VersionNumber> delegateParser)
        {
            this.delegateParser = delegateParser;
        }

        public VersionNumber Parse(string versionNumber)
        {
            return delegateParser(versionNumber);
        }
    }
}
