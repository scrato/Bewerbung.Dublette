using Dublette.Core.CandidateChecker;
using Dublette.Core.Enums;
using Dublette.Core.Extensions;
using Dublette.Core.Files;
using Dublette.Core.Interfaces;
using Dublette.Core.Prefilter;
using Dublette.Core.Wrapper;

namespace Dublette.Core
{
    /// <summary>
    /// Factorymethdode um eine Instanz vom Typ <see cref="IDublettenprüfung"/> zu erzeugen
    /// </summary>
    public class DublettenprüfungFactory
    {


        private readonly IoCWrapper.IoCInitializator _init;


        /// <summary>
        /// Instanziert die Factory und befüllt den IoC-Container mit Standardwerten vor
        /// </summary>
        private DublettenprüfungFactory()
        {
            _init = new IoCWrapper.IoCInitializator();
            RegisterDefaultAlgorithms();
            RegisterDefaultCandidateChecker();
            RegisterDefaultFileCollector();
        }

        /// <summary>
        /// Ruft den Bau der Dublettenprüfung auf
        /// </summary>
        /// <returns></returns>
        public static DublettenprüfungFactory Build()
        {
            return new DublettenprüfungFactory();
        }


        /// <summary>
        /// Erzeugt das konfigurierte Ergebnisobjekt
        /// </summary>
        /// <returns></returns>
        public IDublettenprüfung Create()
        {
            var ioC = new IoCWrapper(_init);
            return new Dublettenprüfung(ioC);
        }

        /// <summary>
        /// Überschreibt einen übergebenen Algorithmus
        /// </summary>
        /// <typeparam name="T">Der Typ der Prefilter-Klasse die überschrieben werden soll</typeparam>
        /// <param name="modus">Der Modus der mit dem übergebenen Typ überschrieben werden soll</param>
        /// <returns></returns>
        public DublettenprüfungFactory OverrideAlgorithm<T>(Vergleichsmodi modus) where T : class, IFilePrefilter
        {
            _init.Register<IFilePrefilter, T>(modus);
            return this;
        }

        /// <summary>
        /// Überschreibt den Ermittler für Dateipfade
        /// Default: <see cref="FileCollector"/>
        /// </summary>
        /// <param name="fileCollector">Der konkrete FileCollector, welcher die Dateien sammelt</param>
        /// <returns></returns>
        public DublettenprüfungFactory OverrideFileCollector(IFileCollector fileCollector)
        {
            _init.RegisterInstance<IFileCollector>(fileCollector);
            return this;
        }

        /// <summary>
        /// Registriert alle bekannten Algorithmen im UnityContainer
        /// </summary>
        private void RegisterDefaultAlgorithms()
        {
            _init.Register<IFilePrefilter, CompareSizePrefilter>(Vergleichsmodi.Größe);
            _init.Register<IFilePrefilter, CompareSizeAndNamePrefilter>(Vergleichsmodi.Größe_und_Name);
        }


        /// <summary>
        /// Registriert die Klassen zur Sammlung der Dateien
        /// </summary>
        private void RegisterDefaultFileCollector()
        {
            _init.Register<IFileCollector, FileCollector>();
        }


        /// <summary>
        /// Registriert die Klassen zur Prüfung der Kandidaten
        /// </summary>
        private void RegisterDefaultCandidateChecker()
        {
            _init.Register<ICandidateChecker, MD5CandidateChecker>();
        }
    }
}
