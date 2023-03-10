using Dublette.Core.Extensions;
using Dublette.Core.Interfaces;
using Dublette.Core.Wrapper;

namespace Dublette.Core.Files
{
    /// <summary>
    /// Klasse, die Dateien aus dem Dateiverzeichnis ermittelt
    /// </summary>
    public class FileCollector : IFileCollector
    {
        /// <summary>
        /// Sammelt alle Dateien in dem übergebenen Pfad und gibt sie als Auflistung von <see cref="IFileInfo"/> zurück
        /// </summary>
        /// <param name="pfad">Der Pfad, innerhalb dessen die Dateien gesammelt werden sollen</param>
        /// <returns></returns>
        public IReadOnlyCollection<IFileInfo> Collect(string pfad)
        {
            var info = new DirectoryInfo(pfad);
            return info.GetFiles("*.*", SearchOption.AllDirectories)
                .Select(f => new FileInfoWrapper(f))
                .ToReadOnly();
        }
    }
}
