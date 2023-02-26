using Dublette.Core;
using Dublette.Core.Enums;
using Dublette.Test.Extensions;
using Dublette.Test.Mock;

namespace Dublette.Test.Algorithm
{
    /// <summary>
    /// Testklasse f�r den Algorithmus <see cref="Core.Algorithms.GroesseAlgorithm"/>
    /// </summary>
    [TestClass]
    public class DubletteGroesseUndNameTest
    {

        /// <summary>
        /// Pr�ft, ob die Standardvergleichsmethode Gr��e und Name ist
        /// </summary>
        [TestMethod]
        public void IsStandard()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo("A", 100), new MockFileInfo("A", 100), new MockFileInfo("B", 150), new MockFileInfo("A", 150) }
                .ToDefaultDublettenpr�fung();

            //Act 
            var resultStandard = pruefung.Sammle_Kandidaten(string.Empty); //Ohne Modus
            var resultGroesse = pruefung.Sammle_Kandidaten(string.Empty, Vergleichsmodi.Gr��e_und_Name); // Mit Modus

            //Assert
            Assert.IsTrue(resultGroesse.Count == resultStandard.Count, "Standardvergleichsmodus findet eine andere Anzahl an Dubletten zum Vergleichsmodus Gr��e und Name");
            //Nun gehe eines der beiden Listen durch und schaue ob du zu jedem Element ein Gegenst�ck findest.
            //Ist dies der Fall => Gleichheit
            foreach (var dublette in resultStandard)
            {
                Assert.IsTrue(resultGroesse.Any(r => r.Dateipfade.All(p => dublette.Dateipfade.Contains(p))), 
                    $"Die Dublettenliste {String.Join('/', dublette.Dateipfade)} ist im Standard aber nicht im Vergleich enthalten");
            }


        }

        /// <summary>
        /// Pr�ft ein positives Dublettenergebnis von zwei gleich gro�en Dateien mit gleichem Namen
        /// </summary>
        [TestMethod]
        public void TwoEqualFiles()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo("A", 100), new MockFileInfo("A", 100) }
                .ToDefaultDublettenpr�fung();

            //Act
            var candidates = pruefung.Sammle_Kandidaten(string.Empty, Vergleichsmodi.Gr��e_und_Name);

            //Assert
            Assert.IsTrue(candidates.Count == 1, $"Es wurde ein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
            var candidat = candidates.Single();
            Assert.IsTrue(candidat.Dateipfade.Count == 2, $"Im Kandidat wurden zwei gleiche potentielle Dubletten erwartet, gefunden wurden jedoch {candidat.Dateipfade.Count}");
        }

        /// <summary>
        /// Zwei Dateien mit unterschiedlichem Namen sollten unterschiedlich gro�e Ergebnisse liefern
        /// </summary>
        [TestMethod]
        public void TwoUnequalFilesBySize()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo(100), new MockFileInfo(150) }
                   .ToDefaultDublettenpr�fung();

            //Act
            var candidates = pruefung.Sammle_Kandidaten(string.Empty);

            //Assert
            Assert.IsTrue(candidates.Count == 0, $"Es wurde kein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
        }

        [TestMethod]
        public void TwoUnequalFilesByName()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo("A"), new MockFileInfo("B") }
                            .ToDefaultDublettenpr�fung();

            //Act
            var candidates = pruefung.Sammle_Kandidaten(string.Empty, Vergleichsmodi.Gr��e_und_Name);

            //Assert
            Assert.IsTrue(candidates.Count == 0, $"Es wurde kein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
        }

        [TestMethod]
        public void TwoUnequalFilesByNameAndSize()
        {
            //Arrange
            var pruefung = new[] { new MockFileInfo("A", 100), new MockFileInfo("B", 100) }
                .ToDefaultDublettenpr�fung();

            //Act
            var candidates = pruefung.Sammle_Kandidaten(string.Empty, Vergleichsmodi.Gr��e_und_Name);

            //Assert
            Assert.IsTrue(candidates.Count == 0, $"Es wurde kein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
        }
    }
}