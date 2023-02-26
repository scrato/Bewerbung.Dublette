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
        /// </summary>
        /// <param name="pfad"></param>
        /// <returns></returns>
        IReadOnlyCollection<IDublette> Sammle_Kandidaten(string pfad);

        /// <summary>
        /// Prüft alle Dateien im übergebenen Pfad mit dem per <see cref="Vergleichsmodi"/> übergebenen Algorithmus
        /// </summary>
        /// <param name="pfad"></param>
        /// <param name="modus"></param>
        /// <returns></returns>
        IReadOnlyCollection<IDublette> Sammle_Kandidaten(string pfad, Vergleichsmodi modus);
        /// <summary>
        /// Prüft die als mögliche Dublette gefundenen Kandidaten und vergleicht diese mittels <see cref="System.Security.Cryptography.MD5"/> Hash
        /// </summary>
        /// <param name="kandidaten"></param>
        /// <returns></returns>
        IReadOnlyCollection<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten);


        //Weitere Vorschläge:
        //- Zusätzlich zur MD5-Prüfung bei Gleichheit noch einen Binärvergleich ermöglichen (ggf. optional, ebenfalls über Modi) um false positives bei Hashvergleichen auszuschließen
        //- Korrespondierende Async-Methoden damit während die Sammlungen aufgebaut oder validiert wird, im Hauptprogramm weiter gearbeitet werden kann und per await das Hauptprogramm wieder zum Ausführungsfluss zurückkehrt
        //- Implementation von Cancellationtoken um die Prozesse anhaltbar zu machen
        //- Vergleichsmodi als Flags umsetzen, da es ja vll später erweitert werden kann. So könnte ich ein Flag aus Size / Name / Drittem Attribut in beliebiger Reihenfolge umsetzen
        //- Func<string> oder Func<IStatusProgress> in Factory übergeben, damit bei der Prüfung (die ja länger dauern kann) ein Status mitgegeben wird
        //- Umlaute im Interface vermeiden
    }
}
