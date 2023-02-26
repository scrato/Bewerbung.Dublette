# Bewerbung.Dublette

Eine Bibliothek und Kommandozeilenapplikation um Dubletten innerhalb einer Ordnerstruktur zu identifizieren.


# Instanzierung
Im u.g. Beispiel sieht man die Instanzierung einer DublettenprüfungFactory

```mermaid
sequenceDiagram
    actor Aufrufer
    participant DublettenprüfungFactory
    participant Dublettenprüfung
    Aufrufer->>DublettenprüfungFactory: Build()
    DublettenprüfungFactory-->>Aufrufer: DublettenprüfungFactory
    Note left of DublettenprüfungFactory: Ggf. eigene Algorithmen / Prüfmethoden überladen
    Aufrufer->>DublettenprüfungFactory: Create()
    DublettenprüfungFactory-->>Aufrufer: Default: Dublettenprüfung
    Aufrufer->>+Dublettenprüfung: Hier kann nun auf das Dublettenprüfung-Objekt zugegriffen werden
```

# Vergleiche
Ist die Dublettenprüfung-Klasse instanziert, beinhaltet sie folgende Aufrufe zur Ausführung der Vergleichslogik:
```mermaid
---
title: Aufbau IDublettenprüfung
---
classDiagram
    class IDublettenprüfung
    <<Interface>> IDublettenprüfung
        IDublettenprüfung : SammleKandidaten(string pfad) IReadOnlyCollection~IDublette~
        IDublettenprüfung : SammleKandidaten(string pfad, Vergleichsmodi modus) IReadOnlyCollection~IDublette~
        IDublettenprüfung : Prüfe_Kandidaten(IEnumerable~IDublette~ kandidaten) IReadOnlyCollection~IDublette~
    class IDublette{
        <<Interface>>
        +IReadOnlyCollection~string~ Dateipfade
    }
    class Vergleichsmodus{
        <<Enumeration>>
        Größe_und_Name
        Größe
    }
     
```
        


# Weitere Schritte

        //Weitere Vorschläge:
        //- Zusätzlich zur MD5-Prüfung bei Gleichheit noch einen Binärvergleich ermöglichen (ggf. optional, ebenfalls über Modi) um false positives bei Hashvergleichen auszuschließen
        //- Korrespondierende Async-Methoden damit während die Sammlungen aufgebaut oder validiert wird, im Hauptprogramm weiter gearbeitet werden kann und per await das Hauptprogramm wieder zum Ausführungsfluss zurückkehrt
        //- Implementation von Cancellationtoken um die Prozesse anhaltbar zu machen
        //- Vergleichsmodi als Flags umsetzen, da es ja vll später erweitert werden kann. So könnte ich ein Flag aus Size / Name / Drittem Attribut in beliebiger Reihenfolge umsetzen
        //- Umlaute im Interface vermeiden
