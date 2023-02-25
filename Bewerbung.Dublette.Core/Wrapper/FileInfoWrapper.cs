using Dublette.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Wrapper
{
    /// <summary>
    /// Wrapper-Klasse für <see cref="FileInfo"/> 
    /// </summary>
    internal class FileInfoWrapper : IFileInfo
    {
        private readonly FileInfo _info;

        public long Size => _info.Length;

        public string Path => _info.FullName;

        public string FileName => _info.Name;

        public FileInfoWrapper(FileInfo info)
        {
            _info = info;
        }
    }
}
