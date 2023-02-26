using Dublette.Core.Extensions;
using Dublette.Core.Interfaces;

namespace Dublette.Test.Mock
{
    internal class MockCandidate : IDublette
    {
        public MockCandidate(IEnumerable<string> pfade) { Dateipfade = pfade.ToReadOnly(); }
        public IReadOnlyCollection<string> Dateipfade { get; }
    }
}
