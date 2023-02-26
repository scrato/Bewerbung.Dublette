using Dublette.Core.Interfaces;
using System.ComponentModel;

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
