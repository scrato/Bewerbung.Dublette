using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dublette.Core.Interfaces;

namespace Dublette.Core.Enums
{
    /// <summary>
    /// Die möglichen Modis um Dateien vorzufiltern, bevor diese Ergebnismenge in den Hashvergleich gegeben wird.
    /// Wird von <see cref="IFilePrefilter"/> mit Logik befüllt
    /// </summary>
    public enum Vergleichsmodi
    {
        [Description("Größe und Name")]
        Größe_und_Name,
        [Description("Größe")]
        Größe
    }
}
