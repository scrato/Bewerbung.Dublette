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
    public class CompareSizeAlgorithm : AlgorithmBase
    {
        public CompareSizeAlgorithm() :base(Vergleichsmodi.Größe) { }


        /// <summary>
        /// Hier wird auf die Dateigröße gefiltert
        /// </summary>
        protected override Func<IFileInfo, object> Filter => (f) => f.Size;
    }
}
