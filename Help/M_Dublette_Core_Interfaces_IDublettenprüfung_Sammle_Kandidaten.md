# Sammle_Kandidaten(String) Methode


Prüft alle Dateien im übergebenen Pfad anhand von Größe und Namen auf Gleichheit Nutzt den Standardmodus <a href="T_Dublette_Core_Enums_Vergleichsmodi.md">Größe_und_Name</a>



## Definition
**Namensraum:** <a href="N_Dublette_Core_Interfaces.md">Dublette.Core.Interfaces</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
IReadOnlyCollection<IDublette> Sammle_Kandidaten(
	string pfad
)
```
**VB**
``` VB
Function Sammle_Kandidaten ( 
	pfad As String
) As IReadOnlyCollection(Of IDublette)
```
**C++**
``` C++
IReadOnlyCollection<IDublette^>^ Sammle_Kandidaten(
	String^ pfad
)
```
**F#**
``` F#
abstract Sammle_Kandidaten : 
        pfad : string -> IReadOnlyCollection<IDublette> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>Der Pfad, in dessen Dateistruktur nach möglichen Dubletten gesucht werden soll</dd></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_Interfaces_IDublette.md">IDublette</a>)  
Die Liste von Dubletten, die möglicherweise identisch sein können

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Interfaces_IDublettenprüfung.md">IDublettenprüfung Schnittstelle</a>  
<a href="Overload_Dublette_Core_Interfaces_IDublettenprüfung_Sammle_Kandidaten.md">Sammle_Kandidaten Überladung</a>  
<a href="N_Dublette_Core_Interfaces.md">Dublette.Core.Interfaces Namensraum</a>  
