using Dublette.Core;
using Dublette.Test.Mock;

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
