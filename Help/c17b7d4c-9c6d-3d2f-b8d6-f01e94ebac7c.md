# Resolve&lt;T&gt;(String) Methode


Baut mittels des Autofac-Containers mit dem übergebenen Key den übergebenen Typ zusammen



## Definition
**Namensraum:** <a href="b632e171-a31d-f133-51da-48d1493f66e8">Dublette.Core.Wrapper</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public T Resolve<T>(
	string key
)
where T : class

```
**VB**
``` VB
Public Function Resolve(Of T As Class) ( 
	key As String
) As T
```
**C++**
``` C++
public:
generic<typename T>
where T : ref class
T Resolve(
	String^ key
)
```
**F#**
``` F#
member Resolve : 
        key : string -> 'T  when 'T : not struct
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>Der key, der den Typen näher differnziert</dd></dl>

#### Typenparameter
<dl><dt /><dd>Der Typ / Das Interface des Objektes, welches erstellt werden soll</dd></dl>

#### Rückgabewert
T  
\[Missing &lt;returns&gt; documentation for "M:Dublette.Core.Wrapper.IoCWrapper.Resolve``1(System.String)"\]

## Siehe auch


#### Referenz
<a href="6fc49c28-4382-0864-2cb4-b933ee9db411">IoCWrapper Klasse</a>  
<a href="b7ce6756-f823-1983-33cd-bf6b83a1f82b">Resolve Überladung</a>  
<a href="b632e171-a31d-f133-51da-48d1493f66e8">Dublette.Core.Wrapper Namensraum</a>  
