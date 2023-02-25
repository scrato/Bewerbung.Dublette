namespace Dublette.Core.Interfaces
{
    public interface IFileCollector
    {
        /// <summary>
        /// Sammelt alle Dateien innerhalb eines Pfades und fügt sie in das IFileInfo Interface
        /// </summary>
        /// <param name="pfad"></param>
        /// <returns></returns>
        IReadOnlyCollection<IFileInfo> Collect(string pfad);
    }
}