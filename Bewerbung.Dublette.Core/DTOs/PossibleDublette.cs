using Dublette.Core.Interfaces;

namespace Dublette.Core.DTOs
{
    /// <summary>
    /// Klasse, die Dateidupletten zusammenhält
    /// </summary>
    public class PossibleDublette : IDublette
    {
        public PossibleDublette(IReadOnlyCollection<IFileInfo> fileInfos)
        {
            FileInfos = fileInfos;
        }


        /// <summary>
        /// Die FileInfos die als aktuell mögliche Dublette interpretiert sind
        /// </summary>
        public IReadOnlyCollection<IFileInfo> FileInfos { get; }

        /// <summary>
        /// Gibt die Dateipfade zurück, die in den als Dublette gefundenen FileInfos vorhanden sind
        /// </summary>
        public IReadOnlyCollection<string> Dateipfade => FileInfos.Select(c => c.Path).ToReadOnly();
    }
}
