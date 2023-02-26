# Register&lt;I, T&gt;(String) Methode


Registriert einen Typ, der von einem Interface ableitet im IoC-Container. Hierbei wird der Key zur Unterscheidung genommen, sodass man hier mit dem übergebenen key resolven muss.



## Definition
**Namensraum:** <a href="N_Dublette_Core_Wrapper.md">Dublette.Core.Wrapper</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public void Register<I, T>(
	string key
)
where I : class
where T : I

```
**VB**
``` VB
Public Sub Register(Of I As Class, T As I) ( 
	key As String
)
```
**C++**
``` C++
public:
generic<typename I, typename T>
where I : ref class
where T : I
void Register(
	String^ key
)
```
**F#**
``` F#
member Register : 
        key : string -> unit  when 'I : not struct when 'T : 'I
```



#### Parameter
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>Der Schlüsselparameter unter dem das Objekt aus dem IoC-Container herausgeholt wird</dd></dl>

#### Typenparameter
<dl><dt /><dd>Das Interface, welches den Typen implementiert</dd><dt /><dd>Der konkrete Typ der instanziert werden soll</dd></dl>

## Siehe auch


#### Referenz
<a href="T_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator.md">IoCWrapper.IoCInitializator Klasse</a>  
<a href="Overload_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator_Register.md">Register Überladung</a>  
<a href="N_Dublette_Core_Wrapper.md">Dublette.Core.Wrapper Namensraum</a>  
