using Dublette.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{
    /// <summary>
    /// Das Interface zur Dublettenprüfung
    /// </summary>
    public interface IDublettenprüfung
    {

        /// <summary>
        /// Prüft alle Dateien im übergebenen Pfad anhand von Größe und Namen auf Gleichheit
        /// Nutzt den Standardmodus <see cref="Vergleichsmodi.Größe_und_Name"/>
        /// </summary>
        /// <param name="pfad">Der Pfad, in dessen Dateistruktur nach möglichen Dubletten gesucht werden soll</param>
        /// <returns>Die Liste von Dubletten, die möglicherweise identisch sein können</returns>
        IReadOnlyCollection<IDublette> Sammle_Kandidaten(string pfad);

        /// <summary>
        /// Prüft alle Dateien im übergebenen Pfad mit dem per <see cref="Vergleichsmodi"/> übergebenen <see cref="IFilePrefilter"/>
        /// </summary>
        /// <param name="pfad">Der Pfad, in dessen Dateistruktur nach möglichen Dubletten gesucht werden soll</param>
        /// <param name="modus"></param>
        /// <returns>Die Liste von Dubletten, die möglicherweise identisch sein können</returns>
        IReadOnlyCollection<IDublette> Sammle_Kandidaten(string pfad, Vergleichsmodi modus);

        /// <summary>
        /// Prüft die als mögliche Dublette gefundenen Kandidaten und vergleicht diese mittels <see cref="System.Security.Cryptography.MD5"/> Hash
        /// </summary>
        /// <param name="kandidaten">Die potentiell identischen Dubletten</param>
        /// <returns>Die Liste von Dubletten, die per Prüfung noch als eindeutig identifiziert wurden.</returns>
        IReadOnlyCollection<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten);
    }
}
