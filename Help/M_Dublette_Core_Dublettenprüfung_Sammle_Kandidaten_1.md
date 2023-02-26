# Sammle_Kandidaten(String, Vergleichsmodi) Methode


Sammelt die Kandidaten anhand des übergebenen Pfades und mittels des übergebenen Vergleichsmodus



## Definition
**Namensraum:** <a href="N_Dublette_Core.md">Dublette.Core</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public IReadOnlyCollection<IDublette> Sammle_Kandidaten(
	string pfad,
	Vergleichsmodi modus
)
```
**VB**
``` VB
Public Function Sammle_Kandidaten ( 
	pfad As String,
	modus As Vergleichsmodi
) As IReadOnlyCollection(Of IDublette)
```
**C++**
``` C++
public:
virtual IReadOnlyCollection<IDublette^>^ Sammle_Kandidaten(
	String^ pfad, 
	Vergleichsmodi modus
) sealed
```
**F#**
``` F#
abstract Sammle_Kandidaten : 
        pfad : string * 
        modus : Vergleichsmodi -> IReadOnlyCollection<IDublette> 
override Sammle_Kandidaten : 
        pfad : string * 
        modus : Vergleichsmodi -> IReadOnlyCollection<IDublette> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>Der Pfad, aus dem die Dateien ermittelt werden sollen</dd><dt>  <a href="T_Dublette_Core_Enums_Vergleichsmodi.md">Vergleichsmodi</a></dt><dd>Der Vergleichsmodus der ausgeführt werden soll</dd></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_Interfaces_IDublette.md">IDublette</a>)  
\[Missing &lt;returns&gt; documentation for "M:Dublette.Core.Dublettenprüfung.Sammle_Kandidaten(System.String,Dublette.Core.Enums.Vergleichsmodi)"\]

#### Implementiert
<a href="M_Dublette_Core_Interfaces_IDublettenprüfung_Sammle_Kandidaten_1.md">IDublettenprüfung.Sammle_Kandidaten(String, Vergleichsmodi)</a>  


## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Dublettenprüfung.md">Dublettenprüfung Klasse</a>  
<a href="Overload_Dublette_Core_Dublettenprüfung_Sammle_Kandidaten.md">Sammle_Kandidaten Überladung</a>  
<a href="N_Dublette_Core.md">Dublette.Core Namensraum</a>  
