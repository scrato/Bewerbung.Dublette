using Dublette.Core.Enums;
using Dublette.Core.Interfaces;
using Dublette.Core.Wrapper;

namespace Dublette.Core.Extensions
{
    /// <summary>
    /// Die Erweiterungsklasse für den IoC-Container um Vergleichsmodus als Enum einheitlich zu speichern.
    /// </summary>
    public static class IoCExtension
    {
        /// <summary>
        /// Registriert einen neuen <see cref="IFilePrefilter"/> mit übergebenen <see cref="Vergleichsmodi"/> 
        /// einmal per Interface und einmal als direkt zugreifbares Objekt
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="init"></param>
        /// <param name="modus"></param>
        internal static void Register<I, T>(this IoCWrapper.IoCInitializator init, Vergleichsmodi modus)
            where T : class, I
            where I : class, IFilePrefilter
        {
            init.Register<I, T>(modus.ToString());
            init.Register<T>();
        }

        /// <summary>
        /// Ermittelt den <see cref="IFilePrefilter"/> über den registrierten <see cref="Vergleichsmodi"/>
        /// </summary>
        /// <param name="ioc"></param>
        /// <param name="modus"></param>
        /// <returns></returns>
        internal static IFilePrefilter Resolve(this IoCWrapper ioc, Vergleichsmodi modus)
        {
            return ioc.Resolve<IFilePrefilter>(modus.ToString());
        }
    }
}
