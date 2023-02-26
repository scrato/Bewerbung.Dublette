namespace Dublette.Core.Interfaces
{
    /// <summary>
    /// Interface zur Ermittelung der Dateiinformationen für die Dublettenprüfung
    /// </summary>
    public interface IFileCollector
    {
        /// <summary>
        /// Sammelt alle Dateien innerhalb eines Pfades und fügt sie in das IFileInfo Interface
        /// </summary>
        /// <param name="pfad">Der Pfad unter dessen nach Dateien gesucht werden soll</param>
        /// <returns>Die Liste aller Dateien als Dateiinformationsobjekt</returns>
        IReadOnlyCollection<IFileInfo> Collect(string pfad);
    }
}