# FilePrefilterBase Klasse


Basisklasse, unter welcher die Filter implementiert werden, die zur Vorermittlung potentieller Dubletten genutzt werden sollen



## Definition
**Namensraum:** <a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public abstract class FilePrefilterBase : IFilePrefilter
```
**VB**
``` VB
Public MustInherit Class FilePrefilterBase
	Implements IFilePrefilter
```
**C++**
``` C++
public ref class FilePrefilterBase abstract : IFilePrefilter
```
**F#**
``` F#
[<AbstractClassAttribute>]
type FilePrefilterBase = 
    class
        interface IFilePrefilter
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  FilePrefilterBase</td></tr>
<tr><td><strong>Derived</strong></td><td><a href="T_Dublette_Core_Prefilter_CompareSizePrefilter.md">Dublette.Core.Prefilter.CompareSizePrefilter</a></td></tr>
<tr><td><strong>Implements</strong></td><td><a href="T_Dublette_Core_Interfaces_IFilePrefilter.md">IFilePrefilter</a></td></tr>
</table>



## Konstruktoren
<table>
<tr>
<td><a href="M_Dublette_Core_Prefilter_FilePrefilterBase__ctor.md">FilePrefilterBase</a></td>
<td>Erzeugt eine neue Instanz der Filterklasse und setzt den Modus</td></tr>
</table>

## Eigenschaften
<table>
<tr>
<td><a href="P_Dublette_Core_Prefilter_FilePrefilterBase_Filter.md">Filter</a></td>
<td>Die zu überschreibende Methode die ein Filterobjekt zurückgeben soll, nach dem die Ergebnismenge an Dateien gruppiert wird.</td></tr>
<tr>
<td><a href="P_Dublette_Core_Prefilter_FilePrefilterBase_Mode.md">Mode</a></td>
<td>Der Vergleichsmodus, den der Prefilter implementiert</td></tr>
</table>

## Methoden
<table>
<tr>
<td><a href="M_Dublette_Core_Prefilter_FilePrefilterBase_CompareFiles.md">CompareFiles</a></td>
<td>Vergleicht die übergebenen Dateiinfos mit dem hinterlegten Filter</td></tr>
</table>

## Siehe auch


#### Referenz
<a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter Namensraum</a>  
