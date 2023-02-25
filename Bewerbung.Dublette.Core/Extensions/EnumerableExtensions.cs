using Dublette.Core.DTOs;
using Dublette.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core
{
    public static class EnumerableExtensions
    {

        /// <summary>
        /// Wandelt eine Enumerable-Auflistung in eine ReadOnly-Auflistung um
        /// </summary>
        /// <param name="list"></param>
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
        public static List<PossibleDublette> ToPossibleDublette<T>(this IEnumerable<IGrouping<T,IFileInfo>> grouping)
        {
            return grouping.Select(g => new PossibleDublette(g.ToReadOnly())).ToList();
        }
    }
}
