using Dublette.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.DTOs
{
    /// <summary>
    /// Die per Hashvergleich festgestellte Dublette
    /// </summary>
    internal class HashDublette : IDublette
    {

        /// <summary>
        /// Erzeugt eine neue Instanz der Klasse und setzt die übergebenen Dateipfade als Dubletten
        /// </summary>
        /// <param name="paths"></param>
        public HashDublette(IEnumerable<string> paths) { Dateipfade = paths.ToReadOnly(); }

        /// <summary>
        /// Gibt die für die Dublette gefundenen Dateipfade zurück
        /// </summary>
        public IReadOnlyCollection<string> Dateipfade { get; }
    }
}
