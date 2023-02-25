using Dublette.Interfaces.Enums;
using Dublette.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{
    public interface IAlgorithm
    {
        Vergleichsmodi Mode { get; }

        /// <summary>
        /// Vergleicht die übergebene Liste von Dateiinformationen anhand des hinterlegten Modus
        /// </summary>
        /// <param name="files">Die Liste aller Dateiinformationen die verglichen werden soll</param>
        /// <returns></returns>
        IReadOnlyCollection<IDublette> CompareFiles(IReadOnlyCollection<IFileInfo> files);
    }
}
