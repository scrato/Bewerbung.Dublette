# Dublettenprüfung Klasse


Die eigentliche Logiklasse zur Dublettenprüfung



## Definition
**Namensraum:** <a href="N_Dublette_Core">Dublette.Core</a>  
**Assembly:** Dublette.Core (in Dublette.Core.dll) Version: 1.0.0

**C#**
``` C#
public class Dublettenprüfung : IDublettenprüfung
```
**VB**
``` VB
Public Class Dublettenprüfung
	Implements IDublettenprüfung
```
**C++**
``` C++
public ref class Dublettenprüfung : IDublettenprüfung
```
**F#**
``` F#
type Dublettenprüfung = 
    class
        interface IDublettenprüfung
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  Dublettenprüfung</td></tr>
<tr><td><strong>Implements</strong></td><td><a href="T_Dublette_Core_Interfaces_IDublettenprüfung">IDublettenprüfung</a></td></tr>
</table>



## Methoden
<table>
<tr>
<td><a href="M_Dublette_Core_Dublettenprüfung_Create">Create</a></td>
<td>Gibt die Factory zurück um Dublettenprüfung zu erzeugen</td></tr>
<tr>
<td><a href="M_Dublette_Core_Dublettenprüfung_Prüfe_Kandidaten">Prüfe_Kandidaten</a></td>
<td>Prüft die Dublettenkandidaten auf MD5-Gleichheit</td></tr>
<tr>
<td><a href="M_Dublette_Core_Dublettenprüfung_Sammle_Kandidaten">Sammle_Kandidaten(String)</a></td>
<td>Sammelt die Kandidaten anhand des übergebenen Pfades und mittels des Standardvergleichsmodus <a href="T_Dublette_Core_Enums_Vergleichsmodi">Größe_und_Name</a></td></tr>
<tr>
<td><a href="M_Dublette_Core_Dublettenprüfung_Sammle_Kandidaten_1">Sammle_Kandidaten(String, Vergleichsmodi)</a></td>
<td>Sammelt die Kandidaten anhand des übergebenen Pfades und mittels des übergebenen Vergleichsmodus</td></tr>
</table>

## Siehe auch


#### Referenz
<a href="N_Dublette_Core">Dublette.Core Namensraum</a>  
