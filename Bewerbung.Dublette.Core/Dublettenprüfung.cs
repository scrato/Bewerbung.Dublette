using Dublette.Core.Enums;
using Dublette.Core.Extensions;
using Dublette.Core.Interfaces;
using Dublette.Core.Wrapper;

namespace Dublette.Core
{
    /// <summary>
    /// Die eigentliche Logiklasse zur Dublettenprüfung
    /// </summary>
    public class Dublettenprüfung : IDublettenprüfung
    {
        internal Dublettenprüfung(IoCWrapper wrapper)
        {

            IoC = wrapper;
        }

        /// <summary>
        /// Gibt die Factory zurück um <see cref="Dublettenprüfung"/> zu erzeugen
        /// </summary>
        /// <returns></returns>
        public static DublettenprüfungFactory Create()
        { return DublettenprüfungFactory.Build(); }


        /// <summary>
        /// Setzt den IoC-Container 
        /// </summary>
        /// <param name="wrapper"></param>
        internal void SetIoC(IoCWrapper wrapper)
        { this.IoC = wrapper; }



        /// <summary>
        /// Der IoC-Container in dem die Konstruktionsanleitungen für die austauschbaren Objekte enthalten sind
        /// </summary>
        IoCWrapper IoC { get; set; }



        /// <summary>
        /// Prüft die Dublettenkandidaten auf MD5-Gleichheit
        /// </summary>
        /// <param name="kandidaten"></param>
        /// <returns></returns>
        public IReadOnlyCollection<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten)
        {
            var checker = IoC.Resolve<ICandidateChecker>();
            return checker.Check(kandidaten);
        }

        /// <summary>
        /// Sammelt die Kandidaten anhand des übergebenen Pfades und mittels des Standardvergleichsmodus
        /// <see cref="Vergleichsmodi.Größe_und_Name"/>
        /// </summary>
        /// <param name="pfad">Der Pfad, aus dem die Dateien ermittelt werden sollen</param>
        /// <returns></returns>
        public IReadOnlyCollection<IDublette> Sammle_Kandidaten(string pfad)
        {
            return Sammle_Kandidaten(pfad, Vergleichsmodi.Größe_und_Name);
        }

        /// <summary>
        /// Sammelt die Kandidaten anhand des übergebenen Pfades und mittels des übergebenen Vergleichsmodus
        /// </summary>
        /// <param name="pfad">Der Pfad, aus dem die Dateien ermittelt werden sollen</param>
        /// <param name="modus">Der Vergleichsmodus der ausgeführt werden soll</param>
        /// <returns></returns>
        public IReadOnlyCollection<IDublette> Sammle_Kandidaten(string pfad, Vergleichsmodi modus)
        {
            var algo = IoC.Resolve(modus);
            var collector = IoC.Resolve<IFileCollector>();
            var files = collector.Collect(pfad);
            return algo.CompareFiles(files);
        }
    }
}
