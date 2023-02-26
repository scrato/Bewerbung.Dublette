namespace Dublette.Core.Interfaces
{
    /// <summary>
    /// Ergebnisobjekt, welches eine Dublette von mehr als einer Datei entspricht.
    /// Die Datei wird als <see cref="Dateipfade"/> per Pfad gehalten.
    /// </summary>
    public interface IDublette
    {
        /// <summary>
        /// Die Auflistung aller Dateipfade die als Dublette erkannt wurden
        /// </summary>
        IReadOnlyCollection<string> Dateipfade { get; }
    }

}
