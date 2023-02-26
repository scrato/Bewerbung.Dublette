# CompareSizePrefilter Klasse


Der Prefilter, der nach der Dateigröße gruppiert um als Dubletten gefunden zu werden



## Definition
**Namensraum:** <a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public class CompareSizePrefilter : FilePrefilterBase
```
**VB**
``` VB
Public Class CompareSizePrefilter
	Inherits FilePrefilterBase
```
**C++**
``` C++
public ref class CompareSizePrefilter : public FilePrefilterBase
```
**F#**
``` F#
type CompareSizePrefilter = 
    class
        inherit FilePrefilterBase
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  <a href="T_Dublette_Core_Prefilter_FilePrefilterBase.md">FilePrefilterBase</a>  →  CompareSizePrefilter</td></tr>
</table>



## Konstruktoren
<table>
<tr>
<td><a href="M_Dublette_Core_Prefilter_CompareSizePrefilter__ctor.md">CompareSizePrefilter</a></td>
<td>Erzeugt eine neue Instanz für den Größenvergleichsfilter</td></tr>
</table>

## Eigenschaften
<table>
<tr>
<td><a href="P_Dublette_Core_Prefilter_CompareSizePrefilter_Filter.md">Filter</a></td>
<td>Hier wird auf die Dateigröße gefiltert<br />(Überschreibt <a href="P_Dublette_Core_Prefilter_FilePrefilterBase_Filter.md">FilePrefilterBase.Filter</a>)</td></tr>
<tr>
<td><a href="P_Dublette_Core_Prefilter_FilePrefilterBase_Mode.md">Mode</a></td>
<td>Der Vergleichsmodus, den der Prefilter implementiert<br />(Vererbt von <a href="T_Dublette_Core_Prefilter_FilePrefilterBase.md">FilePrefilterBase</a>)</td></tr>
</table>

## Methoden
<table>
<tr>
<td><a href="M_Dublette_Core_Prefilter_FilePrefilterBase_CompareFiles.md">CompareFiles</a></td>
<td>Vergleicht die übergebenen Dateiinfos mit dem hinterlegten Filter<br />(Vererbt von <a href="T_Dublette_Core_Prefilter_FilePrefilterBase.md">FilePrefilterBase</a>)</td></tr>
</table>

## Siehe auch


#### Referenz
<a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter Namensraum</a>  
