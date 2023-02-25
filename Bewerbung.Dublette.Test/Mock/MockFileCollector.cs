using Dublette.Core;
using Dublette.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Test.Mock
{
    /// <summary>
    /// Mock-Klasse um fest gefundene Dateiinfos zurückzugegeben
    /// </summary>
    internal class MockFileCollector : IFileCollector
    {
        private readonly IEnumerable<MockFileInfo> _fileInfos;
        public MockFileCollector(IEnumerable<MockFileInfo> fileInfos) { _fileInfos = fileInfos; }
        public IReadOnlyCollection<IFileInfo> Collect(string pfad)
        {
            return _fileInfos.ToReadOnly();
        }
    }
}
