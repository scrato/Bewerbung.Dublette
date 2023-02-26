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
    public static class IoCExtension
    {
        internal static void Register<I,T>(this IoCWrapper.IoCInitializator init, Vergleichsmodi modus) where T : class, I where I : class
        {
            init.Register<I,T>(modus.ToString());
            init.Register<T>();
        }

        internal static IAlgorithm Resolve(this IoCWrapper ioc,  Vergleichsmodi modus)
        {
            return ioc.Resolve<IAlgorithm>(modus.ToString());
        }
    }
}
