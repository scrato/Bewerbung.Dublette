using Dublette.Core;
using Dublette.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Test.Mock
{
    internal class MockCandidate : IDublette
    {
        public MockCandidate(IEnumerable<string> pfade) { Dateipfade = pfade.ToReadOnly(); }
        public IReadOnlyCollection<string> Dateipfade { get; }
    }
}
