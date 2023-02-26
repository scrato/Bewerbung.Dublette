using Dublette.Core.Enums;
using Dublette.Core.Interfaces;

namespace Dublette.Core.Algorithms
{
    /// <summary>
    /// Die Vorfilterung von potentiellen Dubletten nach Dateinamen und Größe
    /// </summary>
    internal class CompareSizeAndNamePrefilter : FilePrefilterBase
    {
        public CompareSizeAndNamePrefilter() : base(Vergleichsmodi.Größe_und_Name) { }

        /// <summary>
        /// Hier gilt gleicher Dateiname und gleiche Dateigröße
        /// </summary>
        protected override Func<IFileInfo, object> Filter => (f) => new { f.FileName, f.Size };

    }
}
