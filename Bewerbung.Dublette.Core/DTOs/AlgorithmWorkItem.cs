using Dublette.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.DTOs
{
    /// <summary>
    /// Die Klasse die die Objekte während des (oder der) Vergleichsvorgänge hält
    /// </summary>
    public class AlgorithmWorkItem
    {
        
        /// <summary>
        /// Initialisiert den Vergleichslauf. Geht erstmal davon aus, das alle Elemente mögliche Dubletten zueinander sind und filtert alles raus, was keine ist
        /// </summary>
        /// <param name="files"></param>
        public AlgorithmWorkItem(IReadOnlyCollection<IFileInfo> files)
        {
            PossibleDubletten.Add(new PossibleDublette(files));
        }

        /// <summary>
        /// Die Liste der möglichen Dubletten, wird bei den Verarbeitungen neu gesetzt.
        /// </summary>
        public IList<PossibleDublette> PossibleDubletten { get; set; } = new List<PossibleDublette>();
    }
}
