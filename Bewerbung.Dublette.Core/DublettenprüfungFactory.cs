using Dublette.Core.Algorithms;
using Dublette.Core.Interfaces;
using Dublette.Core.Wrapper;
using Dublette.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core
{
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
        public Dublettenprüfung Create()
        {
            var ioC = new IoCWrapper(_init);
            return new Dublettenprüfung(ioC);
        }

        /// <summary>
        /// Überschreibt einen übergebenen Algorithmus
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="modus"></param>
        /// <returns></returns>
        public DublettenprüfungFactory OverrideAlgorithm<T>(Vergleichsmodi modus) where T : class, IAlgorithm
        {
            _init.Register<IAlgorithm, T>(modus);
            return this;
        }

        /// <summary>
        /// Überschreibt den Ermittler für Dateipfade
        /// Default: <see cref="FileCollector"/>
        /// </summary>
        /// <param name="fileCollector"></param>
        /// <returns></returns>
        public DublettenprüfungFactory OverrideFileCollector(IFileCollector fileCollector)
        {
            _init.RegisterInstance<IFileCollector>(fileCollector); 
            return this;
        }

        /// <summary>
        /// Registriert alle bekannten Algorithmen im UnityContainer
        /// </summary>
        /// <param name="init"></param>
        private void RegisterDefaultAlgorithms()
        {
            _init.Register<IAlgorithm, CompareSizeAlgorithm>(Vergleichsmodi.Größe);
            _init.Register<IAlgorithm, CompareSizeAndNameAlgorithm>(Vergleichsmodi.Größe_und_Name);
        }


        /// <summary>
        /// Registriert die Klassen zur Sammlung der Dateien
        /// </summary>
        /// <param name="init"></param>
        private void RegisterDefaultFileCollector()
        {
            _init.Register<IFileCollector, FileCollector>();
        }


        /// <summary>
        /// Registriert die Klassen zur Prüfung der Kandidaten
        /// </summary>
        /// <param name="init"></param>
        private void RegisterDefaultCandidateChecker()
        {
            _init.Register<ICandidateChecker, MD5CandidateChecker>();
        }
    }
}
