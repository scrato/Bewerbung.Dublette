using Dublette.Core.DTOs;
using Dublette.Core.Interfaces;
using Dublette.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dublette.Core
{
    internal class MD5CandidateChecker : ICandidateChecker
    {

        /// <summary>
        /// Prüft die übergebene Liste
        /// </summary>
        /// <param name="kandidaten"></param>
        /// <returns></returns>
        public IReadOnlyCollection<IDublette> Check(IEnumerable<IDublette> kandidaten)
        {
            var result = new ConcurrentBag<IDublette>();
            Parallel.ForEach(kandidaten, k => CheckMD5Items(k, result));
            return result.ToReadOnly();
        }


        /// <summary>
        /// Prüft die einzelne Auflistung an Dubletten mit ihren MD5-Hashwerten und befüllt das mit übergebene Ergebnisobjekt mit neuen Dubletten 
        /// (oder auch keinen, wenn innerhalb der Auflistung kein Element mit gleichem Hash wie ein anderes existiert)
        /// </summary>
        /// <param name="dubletteToCheck"></param>
        /// <param name="result"></param>
        private void CheckMD5Items(IDublette dubletteToCheck, ConcurrentBag<IDublette> result)
        {
            var existingDubletten = dubletteToCheck.Dateipfade
                .GroupBy(p => GetMd5(p))
                .Where(g => g.HasMoreThan(1))
                .Select(g => new HashDublette(g));
            foreach (var dublette in existingDubletten)
            {
                result.Add(dublette);
            }    
        }

        /// <summary>
        /// Ermittelt den Hashwert und gibt ihn per Hexadezimalrepräsentation als String zurück
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string GetMd5(string path)
        {
            using (var md5 = MD5.Create())
            using (var fileStr = new FileStream(path, FileMode.Open))
            {
                return Convert.ToHexString(md5.ComputeHash(fileStr));
            }
        }
    }
}
