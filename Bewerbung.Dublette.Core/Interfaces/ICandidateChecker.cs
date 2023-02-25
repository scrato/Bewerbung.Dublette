using Dublette.Interfaces.Interfaces;

namespace Dublette.Core.Interfaces
{
    internal interface ICandidateChecker
    {
        IReadOnlyCollection<IDublette> Check(IEnumerable<IDublette> kandidaten);
    }
}