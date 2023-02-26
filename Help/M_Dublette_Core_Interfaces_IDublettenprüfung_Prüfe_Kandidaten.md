# Prüfe_Kandidaten Methode


Prüft die als mögliche Dublette gefundenen Kandidaten und vergleicht diese mittels <a href="https://learn.microsoft.com/dotnet/api/system.security.cryptography.md5" target="_blank" rel="noopener noreferrer">MD5</a> Hash



## Definition
**Namensraum:** <a href="N_Dublette_Core_Interfaces">Dublette.Core.Interfaces</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
IReadOnlyCollection<IDublette> Prüfe_Kandidaten(
	IEnumerable<IDublette> kandidaten
)
```
**VB**
``` VB
Function Prüfe_Kandidaten ( 
	kandidaten As IEnumerable(Of IDublette)
) As IReadOnlyCollection(Of IDublette)
```
**C++**
``` C++
IReadOnlyCollection<IDublette^>^ Prüfe_Kandidaten(
	IEnumerable<IDublette^>^ kandidaten
)
```
**F#**
``` F#
abstract Prüfe_Kandidaten : 
        kandidaten : IEnumerable<IDublette> -> IReadOnlyCollection<IDublette> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Dublette_Core_Interfaces_IDublette">IDublette</a>)</dt><dd>Die potentiell identischen Dubletten</dd></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_Interfaces_IDublette">IDublette</a>)  
Die Liste von Dubletten, die per Prüfung noch als eindeutig identifiziert wurden.

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Interfaces_IDublettenprüfung">IDublettenprüfung Schnittstelle</a>  
<a href="N_Dublette_Core_Interfaces">Dublette.Core.Interfaces Namensraum</a>  
