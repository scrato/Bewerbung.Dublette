using Dublette.Core.DTOs;
using Dublette.Core.Interfaces;
using Dublette.Interfaces.Enums;
using Dublette.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Algorithms
{
    internal class CompareSizeAndNameAlgorithm : AlgorithmBase
    {
        private CompareSizeAlgorithm _sizeAlgorithm;

        public CompareSizeAndNameAlgorithm(CompareSizeAlgorithm sizeAlgorithm) : base(Vergleichsmodi.Größe_und_Name)
        {
            _sizeAlgorithm = sizeAlgorithm;
        }

        /// <summary>
        /// Es wird auf den Dateinamen gefiltert
        /// </summary>
        protected override Func<IFileInfo, object> Filter => (f) => new { f.FileName, f.Size };

    }
}
