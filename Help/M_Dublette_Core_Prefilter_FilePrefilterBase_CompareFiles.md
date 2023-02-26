# CompareFiles Methode


Vergleicht die übergebenen Dateiinfos mit dem hinterlegten Filter



## Definition
**Namensraum:** <a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public IReadOnlyCollection<IDublette> CompareFiles(
	IReadOnlyCollection<IFileInfo> files
)
```
**VB**
``` VB
Public Function CompareFiles ( 
	files As IReadOnlyCollection(Of IFileInfo)
) As IReadOnlyCollection(Of IDublette)
```
**C++**
``` C++
public:
virtual IReadOnlyCollection<IDublette^>^ CompareFiles(
	IReadOnlyCollection<IFileInfo^>^ files
) sealed
```
**F#**
``` F#
abstract CompareFiles : 
        files : IReadOnlyCollection<IFileInfo> -> IReadOnlyCollection<IDublette> 
override CompareFiles : 
        files : IReadOnlyCollection<IFileInfo> -> IReadOnlyCollection<IDublette> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_Interfaces_IFileInfo.md">IFileInfo</a>)</dt><dd>\[Missing &lt;param name="files"/&gt; documentation for "M:Dublette.Core.Prefilter.FilePrefilterBase.CompareFiles(System.Collections.Generic.IReadOnlyCollection{Dublette.Core.Interfaces.IFileInfo})"\]</dd></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_Interfaces_IDublette.md">IDublette</a>)  
\[Missing &lt;returns&gt; documentation for "M:Dublette.Core.Prefilter.FilePrefilterBase.CompareFiles(System.Collections.Generic.IReadOnlyCollection{Dublette.Core.Interfaces.IFileInfo})"\]

#### Implementiert
<a href="M_Dublette_Core_Interfaces_IFilePrefilter_CompareFiles.md">IFilePrefilter.CompareFiles(IReadOnlyCollection(IFileInfo))</a>  


## Ausnahmen
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td /></tr>
</table>

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Prefilter_FilePrefilterBase.md">FilePrefilterBase Klasse</a>  
<a href="N_Dublette_Core_Prefilter.md">Dublette.Core.Prefilter Namensraum</a>  
