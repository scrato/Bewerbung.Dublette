# CompareSizePrefilter Klasse


Der Prefilter, der nach der Dateigröße gruppiert um als Dubletten gefunden zu werden



## Definition
**Namensraum:** <a href="5656dd94-029e-d2d0-b330-317b5e2133f4">Dublette.Core.Algorithms</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public class CompareSizePrefilter : FilePrefilterBase
```
**VB**
``` VB
Public Class CompareSizePrefilter
	Inherits FilePrefilterBase
```
**C++**
``` C++
public ref class CompareSizePrefilter : public FilePrefilterBase
```
**F#**
``` F#
type CompareSizePrefilter = 
    class
        inherit FilePrefilterBase
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  <a href="6dbd65a7-ed18-62a3-37f5-6bc0d29d01d5">FilePrefilterBase</a>  →  CompareSizePrefilter</td></tr>
</table>



## Konstruktoren
<table>
<tr>
<td><a href="e977bfaf-0c09-51c9-28db-e82bc71c7104">CompareSizePrefilter</a></td>
<td>Erzeugt eine neue Instanz für den Größenvergleichsfilter</td></tr>
</table>

## Eigenschaften
<table>
<tr>
<td><a href="d72f856e-0a31-a57c-065a-b7db1ea6b42d">Filter</a></td>
<td>Hier wird auf die Dateigröße gefiltert<br />(Überschreibt <a href="2cc2c3b8-319f-2205-5a59-8001683a9b9d">FilePrefilterBase.Filter</a>)</td></tr>
<tr>
<td><a href="a44e7584-9caf-978e-a4e9-21fcbde6462d">Mode</a></td>
<td>Der Vergleichsmodus, den der Prefilter implementiert<br />(Vererbt von <a href="6dbd65a7-ed18-62a3-37f5-6bc0d29d01d5">FilePrefilterBase</a>)</td></tr>
</table>

## Methoden
<table>
<tr>
<td><a href="0e951093-2200-954a-d80f-e4813c024dd5">CompareFiles</a></td>
<td>Vergleicht die übergebenen Dateiinfos mit dem hinterlegten Filter<br />(Vererbt von <a href="6dbd65a7-ed18-62a3-37f5-6bc0d29d01d5">FilePrefilterBase</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Vererbt von <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize#system-object-finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Vererbt von <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode#system-object-gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Serves as the default hash function.<br />(Vererbt von <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype#system-object-gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Vererbt von <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone#system-object-memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Vererbt von <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring#system-object-tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Vererbt von <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Siehe auch


#### Referenz
<a href="5656dd94-029e-d2d0-b330-317b5e2133f4">Dublette.Core.Algorithms Namensraum</a>  
