using Dublette.Core.DTOs;
using Dublette.Core.Interfaces;
using Dublette.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
