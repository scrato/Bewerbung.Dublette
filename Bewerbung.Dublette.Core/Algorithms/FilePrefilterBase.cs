using Dublette.Core.Enums;
using Dublette.Core.Interfaces;

namespace Dublette.Core.Algorithms
{
    /// <summary>
    /// Basisklasse, unter welcher die Filter implementiert werden, die zur Vorermittlung potentieller Dubletten genutzt werden sollen
    /// </summary>
    public abstract partial class FilePrefilterBase : IFilePrefilter
    {

        /// <summary>
        /// Der Vergleichsmodus, den der Prefilter implementiert
        /// </summary>
        public Vergleichsmodi Mode { get; }

        /// <summary>
        /// Die zu überschreibende Methode die ein Filterobjekt zurückgeben soll, nach dem die Ergebnismenge an Dateien gruppiert wird.
        /// </summary>
        protected abstract Func<IFileInfo, Object> Filter { get; }

        /// <summary>
        /// Erzeugt eine neue Instanz der Filterklasse und setzt den Modus
        /// </summary>
        /// <param name="mode"></param>
        protected FilePrefilterBase(Vergleichsmodi mode) { Mode = mode; }

        /// <summary>
        /// Vergleicht die übergebenen Dateiinfos mit dem hinterlegten Filter
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IReadOnlyCollection<IDublette> CompareFiles(IReadOnlyCollection<IFileInfo> files)
        {
            if (files == null) throw new ArgumentNullException(nameof(files));
            return files.GroupBy(f => Filter.Invoke(f))
                                            .Where(g => g.HasMoreThan(1))
                                            .ToPossibleDublette();
        }

    }
}
