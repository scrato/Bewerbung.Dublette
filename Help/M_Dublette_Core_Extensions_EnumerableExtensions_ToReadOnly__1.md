# ToReadOnly&lt;T&gt; Methode


Wandelt eine Enumerable-Auflistung in eine ReadOnly-Auflistung um



## Definition
**Namensraum:** <a href="N_Dublette_Core_Extensions.md">Dublette.Core.Extensions</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public static IReadOnlyCollection<T> ToReadOnly<T>(
	this IEnumerable<T> list
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function ToReadOnly(Of T) ( 
	list As IEnumerable(Of T)
) As IReadOnlyCollection(Of T)
```
**C++**
``` C++
public:
[ExtensionAttribute]
generic<typename T>
static IReadOnlyCollection<T>^ ToReadOnly(
	IEnumerable<T>^ list
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member ToReadOnly : 
        list : IEnumerable<'T> -> IReadOnlyCollection<'T> 
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)</dt><dd>Die Liste, die in eine ReadOnlyCollection verschoben werden soll</dd></dl>

#### Typenparameter
<dl><dt /><dd>\[Missing &lt;typeparam name="T"/&gt; documentation for "M:Dublette.Core.Extensions.EnumerableExtensions.ToReadOnly``1(System.Collections.Generic.IEnumerable{``0})"\]</dd></dl>

#### Rückgabewert
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(T)  
\[Missing &lt;returns&gt; documentation for "M:Dublette.Core.Extensions.EnumerableExtensions.ToReadOnly``1(System.Collections.Generic.IEnumerable{``0})"\]

#### Verwendungshinweise
In Visual Basic und C# können Sie diese Methode als Instanzmethode eines beliebigen Objektes vom Typ <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T) aufrufen. Wenn Sie die Instanzmethodensyntax beim Methodenaufruf anwenden, lassen Sie den ersten Parameter weg. Für weitere Informationen siehe <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Erweiterungsmethoden (C# Programmierhandbuch)</a>.

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Extensions_EnumerableExtensions.md">EnumerableExtensions Klasse</a>  
<a href="N_Dublette_Core_Extensions.md">Dublette.Core.Extensions Namensraum</a>  
