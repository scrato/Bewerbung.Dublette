# Collect Methode


Sammelt alle Dateien innerhalb eines Pfades und fügt sie in das IFileInfo Interface



## Definition
**Namensraum:** <a href="N_Dublette_Core_Interfaces">Dublette.Core.Interfaces</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
IReadOnlyCollection<IFileInfo> Collect(
	string pfad
)
```
**VB**
``` VB
Function Collect ( 
	pfad As String
) As IReadOnlyCollection(Of IFileInfo)
```
**C++**
``` C++
IReadOnlyCollection<IFileInfo^>^ Collect(
	String^ pfad
)
```
**F#**
``` F#
abstract Collect : 
        pfad : string -> IReadOnlyCollection<IFileInfo> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>Der Pfad unter dessen nach Dateien gesucht werden soll</dd></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_Interfaces_IFileInfo">IFileInfo</a>)  
Die Liste aller Dateien als Dateiinformationsobjekt

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Interfaces_IFileCollector">IFileCollector Schnittstelle</a>  
<a href="N_Dublette_Core_Interfaces">Dublette.Core.Interfaces Namensraum</a>  
