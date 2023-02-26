using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{
    /// <summary>
    /// Ergebnisobjekt, welches eine Dublette von mehr als einer Datei entspricht.
    /// Die Datei wird als <see cref="Dateipfade"/> per Pfad gehalten.
    /// </summary>
    public interface IDublette
    {
        IReadOnlyCollection<string> Dateipfade { get; }
    }

}
