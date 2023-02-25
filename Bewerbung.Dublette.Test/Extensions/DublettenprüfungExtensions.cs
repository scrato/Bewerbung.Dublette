using Dublette.Core;
using Dublette.Test.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Test.Extensions
{
    internal static class DublettenprüfungExtensions
    {

        /// <summary>
        /// Wandelt eine Liste von Dateiinfos in das Primäre Dublettenprüfungsobjekt
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public static Dublettenprüfung ToDefaultDublettenprüfung(this IEnumerable<MockFileInfo> files)
        {
            var mockFileCollector = new MockFileCollector(files);
            return DublettenprüfungFactory.Build()
                .OverrideFileCollector(mockFileCollector)
                .Create();
        }
    }
}
