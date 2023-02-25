using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Interfaces.Enums
{
    public enum Vergleichsmodi
    {
        [Description("Größe und Name")]
        Größe_und_Name,
        [Description("Größe")]
        Größe
    }
}
