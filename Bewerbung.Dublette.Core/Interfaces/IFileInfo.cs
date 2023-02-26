using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{
    /// <summary>
    /// Repräsentation eines Dateiinfoobjektes.
    /// Hält alle Werte die für den Eindeutigkeitsvergleich relevant sind.
    /// </summary>
    public interface IFileInfo
    {
        /// <summary>
        /// Der Pfad zur Datei
        /// </summary>
        string Path { get; }
        /// <summary>
        /// Der Dateiname der Datei
        /// </summary>
        string FileName { get; }
        /// <summary>
        /// Die Größe der Datei
        /// </summary>
        long Size { get; }
    }
}
