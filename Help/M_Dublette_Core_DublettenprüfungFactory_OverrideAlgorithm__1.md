# OverrideAlgorithm&lt;T&gt; Methode


Überschreibt einen übergebenen Algorithmus



## Definition
**Namensraum:** <a href="N_Dublette_Core.md">Dublette.Core</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public DublettenprüfungFactory OverrideAlgorithm<T>(
	Vergleichsmodi modus
)
where T : class, IFilePrefilter

```
**VB**
``` VB
Public Function OverrideAlgorithm(Of T As {Class, IFilePrefilter}) ( 
	modus As Vergleichsmodi
) As DublettenprüfungFactory
```
**C++**
``` C++
public:
generic<typename T>
where T : ref class, IFilePrefilter
DublettenprüfungFactory^ OverrideAlgorithm(
	Vergleichsmodi modus
)
```
**F#**
``` F#
member OverrideAlgorithm : 
        modus : Vergleichsmodi -> DublettenprüfungFactory  when 'T : not struct and IFilePrefilter
```



#### Parameter
<dl><dt>  <a href="T_Dublette_Core_Enums_Vergleichsmodi.md">Vergleichsmodi</a></dt><dd>Der Modus der mit dem übergebenen Typ überschrieben werden soll</dd></dl>

#### Typenparameter
<dl><dt /><dd>Der Typ der Prefilter-Klasse die überschrieben werden soll</dd></dl>

#### Rückgabewert
<a href="T_Dublette_Core_DublettenprüfungFactory.md">DublettenprüfungFactory</a>  
\[Missing &lt;returns&gt; documentation for "M:Dublette.Core.DublettenprüfungFactory.OverrideAlgorithm``1(Dublette.Core.Enums.Vergleichsmodi)"\]

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_DublettenprüfungFactory.md">DublettenprüfungFactory Klasse</a>  
<a href="N_Dublette_Core.md">Dublette.Core Namensraum</a>  
