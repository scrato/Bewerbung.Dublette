using Dublette.Core.Enums;
using Dublette.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{

    /// <summary>
    /// Interface um eine Liste von <see cref="IFileInfo"/>s mit einem übergebenen <see cref="Vergleichsmodi"/> auf 
    /// mögliche Eindeutigkeit zu gruppieren
    /// </summary>
    public interface IFilePrefilter
    {
        /// <summary>
        /// Der Modus, den der aktuelle FilePrefilter entspricht
        /// </summary>
        Vergleichsmodi Mode { get; }

        /// <summary>
        /// Vergleicht die übergebene Liste von Dateiinformationen anhand des hinterlegten Modus
        /// </summary>
        /// <param name="files">Die Liste aller Dateiinformationen die verglichen werden soll</param>
        /// <returns></returns>
        IReadOnlyCollection<IDublette> CompareFiles(IReadOnlyCollection<IFileInfo> files);
    }
}
