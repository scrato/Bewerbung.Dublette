using Dublette.Core.DTO;
using Dublette.Core.Interfaces;
using System.Collections.ObjectModel;

namespace Dublette.Core.Extensions
{

    /// <summary>
    /// Erweiterungsmethoden für Operationen auf <see cref="IEnumerable{T}"/> und <see cref="IReadOnlyCollection{T}"/>
    /// </summary>
    public static class EnumerableExtensions
    {

        /// <summary>
        /// Wandelt eine Enumerable-Auflistung in eine ReadOnly-Auflistung um
        /// </summary>
        /// <param name="list">Die Liste, die in eine ReadOnlyCollection verschoben werden soll</param>
        /// <returns></returns>
        public static IReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> list)
        {
            return new ReadOnlyCollection<T>(list.ToList());
        }


        /// <summary>
        /// Prüft, ob die Auflistung mehr als <paramref name="skipAmount"/> Elemente enthält
        /// </summary>
        /// <param name="list">Die zu prüfende Liste</param>
        /// <param name="skipAmount">Die Anzahl der Elemente die enthalten sein dürfen</param>
        /// <returns></returns>
        public static bool HasMoreThan<T>(this IEnumerable<T> list, int skipAmount)
        {
            return list.Skip(skipAmount).Any();
        }


        /// <summary>
        /// Wandelt eine Gruppe von Gruppierungskriterium X und Listen von Dateiinfos zu einer Liste von möglichen Dubletten um
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="grouping"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<PossibleDublette> ToPossibleDublette<T>(this IEnumerable<IGrouping<T, IFileInfo>> grouping)
        {
            return grouping.Select(g => new PossibleDublette(g.ToReadOnly())).ToList();
        }
    }
}
