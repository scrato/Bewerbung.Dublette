# Filter Eigenschaft


Hier wird auf die Dateigröße gefiltert



## Definition
**Namensraum:** <a href="b67fc904-ff12-4792-76cf-2ab90feb928e">Dublette.Core.Prefilter</a>  
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
<a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(<a href="d9482989-6c54-4f59-09d2-458b695230c7">IFileInfo</a>, <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)

## Siehe auch


#### Referenz
<a href="10745c17-cb1f-c1f8-0c44-96bd676db82a">CompareSizePrefilter Klasse</a>  
<a href="b67fc904-ff12-4792-76cf-2ab90feb928e">Dublette.Core.Prefilter Namensraum</a>  
