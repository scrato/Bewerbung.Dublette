using Dublette.Core;
using Dublette.Core.Interfaces;
using Dublette.Core.Enums;
using Dublette.Test.Extensions;
using Dublette.Test.Mock;

namespace Dublette.Test.Algorithm
{
    /// <summary>
    /// Testklasse f�r den Algorithmus <see cref="Core.Algorithms.GroesseAlgorithm"/>
    /// </summary>
    [TestClass]
    public class DubletteGroesseTest
    {



        /// <summary>
        /// Pr�ft ein positives Dublettenergebnis von zwei gleich gro�en Dateien
        /// </summary>
        [TestMethod]
        public void TwoEqualFiles()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo("A", 100), new MockFileInfo("B", 100) }
                            .ToDefaultDublettenpr�fung();

            //Act
            var candidates = pruefung.Sammle_Kandidaten(string.Empty, Vergleichsmodi.Gr��e);

            //Assert
            Assert.IsTrue(candidates.Count == 1, $"Es wurde ein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
            var candidat = candidates.Single();
            Assert.IsTrue(candidat.Dateipfade.Count == 2, $"Im Kandidat wurden zwei gleiche potentielle Dubletten erwartet, gefunden wurden jedoch {candidat.Dateipfade.Count}");
        }

        /// <summary>
        /// Zwei Dateien mit unterschiedlicher Gr��e sollten unterschiedlich gro�e Ergebnisse liefern
        /// </summary>
        [TestMethod]
        public void TwoUnequalFiles()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo(100), new MockFileInfo(150) }
                                    .ToDefaultDublettenpr�fung();

            //Act
            var candidates = pruefung.Sammle_Kandidaten(string.Empty, Vergleichsmodi.Gr��e);

            //Assert
            Assert.IsTrue(candidates.Count == 0, $"Es wurde kein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
        }
    }
}