# IFilePrefilter Schnittstelle


Interface um eine Liste von <a href="T_Dublette_Core_Interfaces_IFileInfo.md">IFileInfo</a>s mit einem übergebenen <a href="T_Dublette_Core_Enums_Vergleichsmodi.md">Vergleichsmodi</a> auf mögliche Eindeutigkeit zu gruppieren



## Definition
**Namensraum:** <a href="N_Dublette_Core_Interfaces.md">Dublette.Core.Interfaces</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public interface IFilePrefilter
```
**VB**
``` VB
Public Interface IFilePrefilter
```
**C++**
``` C++
public interface class IFilePrefilter
```
**F#**
``` F#
type IFilePrefilter = interface end
```



## Eigenschaften
<table>
<tr>
<td><a href="P_Dublette_Core_Interfaces_IFilePrefilter_Mode.md">Mode</a></td>
<td>Der Modus, den der aktuelle FilePrefilter entspricht</td></tr>
</table>

## Methoden
<table>
<tr>
<td><a href="M_Dublette_Core_Interfaces_IFilePrefilter_CompareFiles.md">CompareFiles</a></td>
<td>Vergleicht die übergebene Liste von Dateiinformationen anhand des hinterlegten Modus</td></tr>
</table>

## Siehe auch


#### Referenz
<a href="N_Dublette_Core_Interfaces.md">Dublette.Core.Interfaces Namensraum</a>  
