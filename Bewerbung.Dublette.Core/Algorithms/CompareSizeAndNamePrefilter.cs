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
    /// Die Vorfilterung von potentiellen Dubletten nach Dateinamen und Größe
    /// </summary>
    internal class CompareSizeAndNamePrefilter : FilePrefilterBase
    {
        public CompareSizeAndNamePrefilter() : base(Vergleichsmodi.Größe_und_Name) {}

        /// <summary>
        /// Hier gilt gleicher Dateiname und gleiche Dateigröße
        /// </summary>
        protected override Func<IFileInfo, object> Filter => (f) => new { f.FileName, f.Size };

    }
}
