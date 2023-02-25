using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{
    public interface IFileInfo
    {
        string Path { get; }
        string FileName { get; }
        long Size { get; }
    }
}
