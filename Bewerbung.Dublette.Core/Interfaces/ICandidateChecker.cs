namespace Dublette.Core.Interfaces
{
    /// <summary>
    /// Klasse, die vorgefilterte <see cref="IDublette"/>n mittels Hashvergleich prüft und eine gefilterte Liste zurückgibt
    /// </summary>
    internal interface ICandidateChecker
    {
        IReadOnlyCollection<IDublette> Check(IEnumerable<IDublette> kandidaten);
    }
}