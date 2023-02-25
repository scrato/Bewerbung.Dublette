using Dublette.Core.DTOs;
using Dublette.Core.Interfaces;
using Dublette.Interfaces.Enums;
using Dublette.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core.Algorithms
{
    public abstract partial class AlgorithmBase : IAlgorithm
    {
        public Vergleichsmodi Mode { get; }
        protected abstract Func<IFileInfo, Object> Filter { get; }
        protected AlgorithmBase(Vergleichsmodi mode) { Mode = mode; }


        protected void CompareFiles(AlgorithmWorkItem comparison)
        {
            var newPossibleDubletten = new List<PossibleDublette>();
            //Für jede mögliche gefundene Dublettenkombination schmeiße alles raus, was keine Dublette aus der Sicht der Größe ist.
            foreach (var dublettenListe in comparison.PossibleDubletten)
            {
                //Gruppiert alle Elemente nach Größe, nimmt alle Gruppe mit mehr als einem Element und gibt dieses als Dublettenauflistung zurück
                newPossibleDubletten.AddRange(dublettenListe.FileInfos.GroupBy(f => Filter.Invoke(f))
                                                        .Where(g => g.HasMoreThan(1))
                                                        .ToPossibleDublette());
            }

            comparison.PossibleDubletten = newPossibleDubletten;
        }

        public IReadOnlyCollection<IDublette> CompareFiles(IReadOnlyCollection<IFileInfo> files)
        {
           if (files == null) throw new ArgumentNullException(nameof(files));
            var workItem = new AlgorithmWorkItem(files);
            CompareFiles(workItem);
            return workItem.PossibleDubletten.ToReadOnly();
        }

    }
}
