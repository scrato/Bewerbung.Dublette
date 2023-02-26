using Dublette.Core;
using Dublette.Core.Enums;
using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    //Standards setzen:
    static Vergleichsmodi? modus = Vergleichsmodi.Größe_und_Name;
    static string? pfad = null;

    /// <summary>
    /// Eigentliche Ausführung des Businesscodes
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {

        ConsumeParameters(args);

        if (pfad == null)
        {
            Console.Out.WriteLine("FEHLER: Pflichtparameter -p wurde nicht ausgefüllt!");
            return;
        }

        if (!Directory.Exists(pfad))
        {
            Console.Out.WriteLine($"FEHLER: Der Pfad '{pfad}' existiert nicht!");
            return;
        }

        //Beginn der Businesslogik
        var pruefung = DublettenprüfungFactory.Build().Create();
        var dubletten = pruefung.Sammle_Kandidaten(pfad, modus.GetValueOrDefault());
        dubletten = pruefung.Prüfe_Kandidaten(dubletten);


        Console.Out.WriteLine($"[Vergleichsmodus '{modus}'] Gefundene Dubletten:");
        var dubletteNr = 0;
        foreach (var item in dubletten)
        {
            Console.Out.WriteLine($"--- Dublette Nr {dubletteNr} ---");
            Console.Out.WriteLine($"Folgende Pfade sind identisch:");
            foreach (var dublettenPfad in item.Dateipfade)
            {
                Console.Out.WriteLine($" - '{dublettenPfad}'");
            }
            Console.Out.WriteLine("---------------------------------");
            dubletteNr++;
        }
    }

    /// <summary>
    /// Konsumiert den Folgeparameter. Ist keiner vorhanden wird der übergebene Fehlertext ausgegeben
    /// </summary>
    /// <param name="i">Die Referenz auf den aktuellen Index</param>
    /// <param name="args">Die Auflistung der Argumente</param>
    /// <param name="textBeiFehler">Wenn Element nicht vorhanden, welcher Fehler soll angezeigt werden</param>
    /// <returns></returns>
    private static string? ConsumeNextParam(ref int i, string[] args, string textBeiFehler)
    {
        //Ist das Array am Ende kann das nächste Element nicht konsumiert werden
        if (args.Length <= i + 1)
        {
            Console.Out.WriteLine(textBeiFehler);
            WriteHelpText();
            return null;
        }
        //i weiterzählen, da dieser Parameter abgearbeitet wurde
        i++;
        return args[i];
    }

    /// <summary>
    /// Zeigt die Hilfe über die Parameter am Bildschirm an
    /// </summary>
    private static void WriteHelpText()
    {
        var sb = new StringBuilder();
        sb.AppendLine("---- Dublette ----");
        sb.AppendLine("Eine Kommandozeilenapplikation um Dubletten innerhalb eines Dateisystems zu identifizeren.");
        sb.AppendLine("");
        sb.AppendLine("SYNTAX:");
        sb.AppendLine("    [-fm:FindModus] [-p:Pfad]");
        sb.AppendLine("");
        sb.AppendLine("Pflichtfeld:");
        sb.AppendLine("    -p:Pfad          Der Pfad zur Dateistruktur die nach Dubletten durchsucht werden soll.");
        sb.AppendLine("");
        sb.AppendLine("Optional:");
        sb.AppendLine("    -fm:FindModus    Der Modus, der für die Erstidentfikation von gleichen Dateien genutzt werden soll. [Standard: 'GN' ]");
        sb.AppendLine("                FindModus (GN = Größe und Name / G = Größe)");
        sb.AppendLine("   ");
        sb.AppendLine("AUSGABE:");
        sb.AppendLine("    Die Rückgabe ist eine Liste von Dubletten, die über den primären FindModus gefunden werden und per MD5-Hashvergleich identisch sind.");
        Console.Out.Write(sb.ToString());
    }

    /// <summary>
    /// Extrahiert den Verglecihsmodus aus dem übergebenen String. null wenn ungültige Eingabe
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    private static Vergleichsmodi? ExtractVergleichsmodus(string param)
    {
        switch (param.ToLower())
        {
            case "g":
                return Vergleichsmodi.Größe;
            case "gn":
                return Vergleichsmodi.Größe_und_Name;
            default:
                return null;
        }
    }

    /// <summary>
    /// Extrahiert die Parameter
    /// </summary>
    /// <param name="args">Die übergebenen Parameter</param>
    /// <returns>true wenn erfolgreich, false wenn nicht erfolgreich</returns>
    private static bool ConsumeParameters(string[] args)
    {
        //Gibt es keine Parameter: Hilfetext anzeigen
        if (!args.Any())
        {
            Console.Out.WriteLine("FEHLER: Es wurden keine Parameter angegeben!");
            WriteHelpText();
            return false;
        }

        //Parameter durchgrasen
        int i = 0;
        while (i < args.Length)
        {
            switch (args[i].ToLower())
            {
                case "-help":
                case "-?":
                    WriteHelpText();
                    return false;
                case "-fm":
                    var param = ConsumeNextParam(ref i, args, $"FEHLER: Es wird 'G' oder 'GN' als Parameter erwartet!");
                    if (param == null)
                    { return false; }
                    else
                    {
                        modus = ExtractVergleichsmodus(param);

                        //Wenn Standard überschrieben und plötzlich ungültig, dann aussteigen mit Fehler.
                        if (modus == null)
                        {
                            Console.Out.WriteLine("FEHLER: Es wurde der Parameter -fm angegeben aber kein Vergleichsmodus!");
                            WriteHelpText();
                            return false;
                        }
                    }
                    break;
                case "-p":
                    pfad = ConsumeNextParam(ref i, args, $"FEHLER: Der Pfad wurde nicht angegeben!");
                    return false;
                default:
                    Console.Out.WriteLine($"FEHLER: Parameter '{args[i]}' nicht erkannt.");
                    WriteHelpText();
                    return false;
            }
            i++;
        }

        return true;
    }
}
