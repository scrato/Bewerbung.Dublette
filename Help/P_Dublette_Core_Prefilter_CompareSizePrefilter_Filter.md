# Filter Eigenschaft


Hier wird auf die Dateigröße gefiltert



## Definition
**Namensraum:** <a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
protected override Func<IFileInfo, Object> Filter { get; }
```
**VB**
``` VB
Protected Overrides ReadOnly Property Filter As Func(Of IFileInfo, Object)
	Get
```
**C++**
``` C++
protected:
virtual property Func<IFileInfo^, Object^>^ Filter {
	Func<IFileInfo^, Object^>^ get () override;
}
```
**F#**
``` F#
abstract Filter : Func<IFileInfo, Object> with get
override Filter : Func<IFileInfo, Object> with get
```



#### Eigenschaftswert
<a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(<a href="T_Dublette_Core_Interfaces_IFileInfo.md">IFileInfo</a>, <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Prefilter_CompareSizePrefilter.md">CompareSizePrefilter Klasse</a>  
<a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter Namensraum</a>  
