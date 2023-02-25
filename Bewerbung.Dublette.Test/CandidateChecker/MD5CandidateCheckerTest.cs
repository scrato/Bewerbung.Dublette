using Dublette.Core;
using Dublette.Core.Interfaces;
using Dublette.Interfaces.Enums;
using Dublette.Test.Extensions;
using Dublette.Test.Mock;

namespace Dublette.Test.Algorithm
{
    /// <summary>
    /// Testklasse für den MD5-Vergleich <see cref="MD"/>
    /// </summary>
    [TestClass]
    public class MD5CandidateCheckerTest
    {

        private string? _testPath;

        [TestInitialize]
        public void Setup()
        {
           _testPath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}");
            Directory.CreateDirectory(_testPath);        
        }

        /// <summary>
        /// Fünf Dateien mit gleichem Inhalt sollten eine Ergebnismenge mit fünf Elementen ergeben
        /// </summary>
        [TestMethod]
        public void EqualFiles()
        {
            //Arrange
            var itemCt = 5;
            var pruefung = DublettenprüfungFactory.Build().Create();
            var mockCandidate = new MockCandidate(GenerateFiles(itemCt, "Same"));

            //Act
            var candidates = pruefung.Prüfe_Kandidaten(new[] { mockCandidate });

            //Assert
            Assert.IsTrue(candidates.Count == 1, $"Es wurde ein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
            var candidat = candidates.Single();
            Assert.IsTrue(candidat.Dateipfade.Count == itemCt, $"Im Kandidat wurden zwei gleiche potentielle Dubletten erwartet, gefunden wurden jedoch {candidat.Dateipfade.Count}");
        }

        /// <summary>
        /// Fünf Dateien mit unterschiedlichem Inhalt sollten eine leere Ergebnismenge liefern
        /// </summary>
        [TestMethod]
        public void UnequalFiles()
        {
            //Arrange
            var pruefung = DublettenprüfungFactory.Build().Create();
            var mockCandidate = new MockCandidate(GenerateRandomFiles(5));

            //Act
            var candidates = pruefung.Prüfe_Kandidaten(new[] { mockCandidate });

            //Assert
            Assert.IsTrue(candidates.Count == 0, $"Es wurde kein Kandidat erwartet, gefunden wurden jedoch {candidates.Count}.");
        }

        /// <summary>
        /// Zwei Ergebnisse mit einmal 2x gleichen und 3x verschiedenen und einem Ergebis mit 2x jeweils 2x gleichen und 2 verschiedenen
        /// sollten als drei Ergebnisse mit 2x gleich, 2x gleich und 2x gleich zurückgegeben werden
        /// </summary>
        [TestMethod]
        public void MixedFiles()
        {
            //Arrange

            var sameFiles1 = GenerateFiles(2, "SAME1");
            var sameFiles2 = GenerateFiles(2, "SAME2");
            var sameFiles3 = GenerateFiles(2, "Same3");

            var pruefung = DublettenprüfungFactory.Build().Create();
            var mockCandidates = new[]
                    {
                        new MockCandidate(sameFiles1.Union(GenerateRandomFiles(3))),
                        new MockCandidate(sameFiles2.Union(sameFiles3).Union(GenerateRandomFiles(2)))
                    };

            //Act
            var candidates = pruefung.Prüfe_Kandidaten(mockCandidates);

            //Assert
            Assert.IsTrue(candidates.Count == 3, $"Es wurden mehr Dubletten zurückgegeben [{candidates.Count}] als erwartet [3].");
            foreach (var result in new[] {sameFiles1, sameFiles2, sameFiles3})
            {
                Assert.IsTrue(candidates.Any(c => c.Dateipfade.All(pfad => result.Contains(pfad))), $"Die Auflistung [{result}] wurde nicht in den MD5 vergleichen gefunden.");
            }
        }

        /// <summary>
        /// Generiert Dateien der übergebenen Anzahl mit dem übergebenen Namen
        /// </summary>
        /// <param name="count"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private IEnumerable<string> GenerateFiles(int count, string content)
        {
            var items = new List<string>();
            for (int i = 0; i < count; i++)
            {
                var path = Path.Combine(_testPath + Guid.NewGuid());
                File.WriteAllText(path, content);
                items.Add(path);
            }
            return items;
        }

        /// <summary>
        /// Generiert zufällige unterschiedliche Dateien der übergebenen Anzahl
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private IEnumerable<string> GenerateRandomFiles(int count)
        {
            return Enumerable.Range(0, count).SelectMany(i => GenerateFiles(1, $"{Guid.NewGuid()}"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            new DirectoryInfo(_testPath!).Delete(true);
        }
    }
}