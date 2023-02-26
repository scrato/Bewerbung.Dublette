# ToPossibleDublette&lt;T&gt; Methode


Wandelt eine Gruppe von Gruppierungskriterium X und Listen von Dateiinfos zu einer Liste von möglichen Dubletten um



## Definition
**Namensraum:** <a href="N_Dublette_Core_Extensions">Dublette.Core.Extensions</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public static IReadOnlyCollection<PossibleDublette> ToPossibleDublette<T>(
	this IEnumerable<IGrouping<T, IFileInfo>> grouping
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function ToPossibleDublette(Of T) ( 
	grouping As IEnumerable(Of IGrouping(Of T, IFileInfo))
) As IReadOnlyCollection(Of PossibleDublette)
```
**C++**
``` C++
public:
[ExtensionAttribute]
generic<typename T>
static IReadOnlyCollection<PossibleDublette^>^ ToPossibleDublette(
	IEnumerable<IGrouping<T, IFileInfo^>^>^ grouping
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member ToPossibleDublette : 
        grouping : IEnumerable<IGrouping<'T, IFileInfo>> -> IReadOnlyCollection<PossibleDublette> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(<a href="https://learn.microsoft.com/dotnet/api/system.linq.igrouping-2" target="_blank" rel="noopener noreferrer">IGrouping</a>(T, <a href="T_Dublette_Core_Interfaces_IFileInfo">IFileInfo</a>))</dt><dd /></dl>

#### Typenparameter
<dl><dt /><dd /></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_Dublette_Core_DTO_PossibleDublette">PossibleDublette</a>)  
\[Missing &lt;returns&gt; documentation for "M:Dublette.Core.Extensions.EnumerableExtensions.ToPossibleDublette``1(System.Collections.Generic.IEnumerable{System.Linq.IGrouping{``0,Dublette.Core.Interfaces.IFileInfo}})"\]

#### Verwendungshinweise
In Visual Basic und C# können Sie diese Methode als Instanzmethode eines beliebigen Objektes vom Typ <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(<a href="https://learn.microsoft.com/dotnet/api/system.linq.igrouping-2" target="_blank" rel="noopener noreferrer">IGrouping</a>(T, <a href="T_Dublette_Core_Interfaces_IFileInfo">IFileInfo</a>)) aufrufen. Wenn Sie die Instanzmethodensyntax beim Methodenaufruf anwenden, lassen Sie den ersten Parameter weg. Für weitere Informationen siehe <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Erweiterungsmethoden (C# Programmierhandbuch)</a>.

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Extensions_EnumerableExtensions">EnumerableExtensions Klasse</a>  
<a href="N_Dublette_Core_Extensions">Dublette.Core.Extensions Namensraum</a>  
