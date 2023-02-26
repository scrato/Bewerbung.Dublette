# IoCWrapper.IoCInitializator Klasse


Klasse zum Initalisieren des IoC-Containers



## Definition
**Namensraum:** <a href="N_Dublette_Core_Wrapper.md">Dublette.Core.Wrapper</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public class IoCInitializator
```
**VB**
``` VB
Public Class IoCInitializator
```
**C++**
``` C++
public ref class IoCInitializator
```
**F#**
``` F#
type IoCInitializator = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  IoCWrapper.IoCInitializator</td></tr>
</table>



## Konstruktoren
<table>
<tr>
<td><a href="M_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator__ctor.md">IoCWrapper.IoCInitializator</a></td>
<td>ERzeugt eine neue Klasse zur Registrierung von Objekten im IoC-Container</td></tr>
</table>

## Methoden
<table>
<tr>
<td><a href="M_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator_Register__1.md">Register(T)()</a></td>
<td>Registriert einen einzelnen Typ im IoC-Container, damit dieser resolved werden kann</td></tr>
<tr>
<td><a href="M_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator_Register__2.md">Register(I, T)()</a></td>
<td>Registriert einen Typ, der von einem Interface ableitet im IoC-Container</td></tr>
<tr>
<td><a href="M_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator_Register__2_1.md">Register(I, T)(String)</a></td>
<td>Registriert einen Typ, der von einem Interface ableitet im IoC-Container. Hierbei wird der Key zur Unterscheidung genommen, sodass man hier mit dem übergebenen key resolven muss.</td></tr>
<tr>
<td><a href="M_Dublette_Core_Wrapper_IoCWrapper_IoCInitializator_RegisterInstance__1.md">RegisterInstance(T)</a></td>
<td>Registriert eine Instanz vom Typ T im IoC-Container</td></tr>
</table>

## Siehe auch


#### Referenz
<a href="N_Dublette_Core_Wrapper.md">Dublette.Core.Wrapper Namensraum</a>  
