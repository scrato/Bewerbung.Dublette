# IDublettenprüfung Schnittstelle


Das Interface zur Dublettenprüfung



## Definition
**Namensraum:** <a href="N_Dublette_Core_Interfaces.md">Dublette.Core.Interfaces</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public interface IDublettenprüfung
```
**VB**
``` VB
Public Interface IDublettenprüfung
```
**C++**
``` C++
public interface class IDublettenprüfung
```
**F#**
``` F#
type IDublettenprüfung = interface end
```



## Methoden
<table>
<tr>
<td><a href="M_Dublette_Core_Interfaces_IDublettenprüfung_Prüfe_Kandidaten.md">Prüfe_Kandidaten</a></td>
<td>Prüft die als mögliche Dublette gefundenen Kandidaten und vergleicht diese mittels <a href="https://learn.microsoft.com/dotnet/api/system.security.cryptography.md5" target="_blank" rel="noopener noreferrer">MD5</a> Hash</td></tr>
<tr>
<td><a href="M_Dublette_Core_Interfaces_IDublettenprüfung_Sammle_Kandidaten.md">Sammle_Kandidaten(String)</a></td>
<td>Prüft alle Dateien im übergebenen Pfad anhand von Größe und Namen auf Gleichheit Nutzt den Standardmodus <a href="T_Dublette_Core_Enums_Vergleichsmodi.md">Größe_und_Name</a></td></tr>
<tr>
<td><a href="M_Dublette_Core_Interfaces_IDublettenprüfung_Sammle_Kandidaten_1.md">Sammle_Kandidaten(String, Vergleichsmodi)</a></td>
<td>Prüft alle Dateien im übergebenen Pfad mit dem per <a href="T_Dublette_Core_Enums_Vergleichsmodi.md">Vergleichsmodi</a> übergebenen <a href="T_Dublette_Core_Interfaces_IFilePrefilter.md">IFilePrefilter</a></td></tr>
</table>

## Siehe auch


#### Referenz
<a href="N_Dublette_Core_Interfaces.md">Dublette.Core.Interfaces Namensraum</a>  
