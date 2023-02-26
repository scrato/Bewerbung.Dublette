using Dublette.Core.Enums;
using Dublette.Core.Interfaces;

namespace Dublette.Core.Prefilter
{
    /// <summary>
    /// Der Prefilter, der nach der Dateigröße gruppiert um als Dubletten gefunden zu werden
    /// </summary>
    public class CompareSizePrefilter : FilePrefilterBase
    {

        /// <summary>
        /// Erzeugt eine neue Instanz für den Größenvergleichsfilter
        /// </summary>
        public CompareSizePrefilter() : base(Vergleichsmodi.Größe) { }


        /// <summary>
        /// Hier wird auf die Dateigröße gefiltert
        /// </summary>
        protected override Func<IFileInfo, object> Filter => (f) => f.Size;
    }
}
