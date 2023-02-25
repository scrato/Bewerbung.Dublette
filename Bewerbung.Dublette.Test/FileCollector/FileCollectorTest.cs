using Dublette.Core;
using Dublette.Test.Mock;
using System.Collections.Concurrent;

namespace Dublette.Test
{
    /// <summary>
    /// Testklasse für den Dateicollector <see cref="FileCollector"/>
    /// </summary>
    [TestClass]
    public class FileCollectorTest
    {


        private string? _testPath;

        [TestInitialize]
        public void Setup()
        {
            //Erzeuge 10 Dateien im Tempverzeichnis
            _testPath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}");
            Directory.CreateDirectory(_testPath);

            for (int i = 0; i < 10; i++)
            {
                File.Create(_testPath + "/" + i).Dispose();
            }

        }

        /// <summary>
        /// Prüft ein positives Dublettenergebnis von zwei gleich großen Dateien
        /// </summary>
        [TestMethod]
        public void FindFiles()
        {
            //Arrange
            var collector = new FileCollector();

            //Act
            var result = collector.Collect(_testPath!);

            //Assert
            Assert.IsTrue(result.Count == 10, "Es sind nicht alle Dateien im Testpfad gesammelt worden");
        }

        [TestCleanup]
        public void Cleanup()
        {
            new DirectoryInfo(_testPath!).Delete(true);
        }

    }
}