using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Interfaces
{
    public interface IDublette
    {
        IReadOnlyCollection<string> Dateipfade { get; }
    }

}
