# HIT-Client

Diese Bibliothek stellt Funktionen zur Verfügung, die den Zugriff auf das "[Herkunftssicherungs- und Informationssystem für Tiere](https://www.hi-tier.de/)" mittels C# vereinfacht. [Der Client kommuniziert dafür mit den REST-Endpunkten des Systems](https://www4.hi-tier.de/Entwicklung/Technik/REST-Service.html). [Die Dokumentation für Entwickler ist daher eine wichtige Ressource für die Nutzung dieser Bibliothek](https://www4.hi-tier.de/Entwicklung/default.htm).

# Verwendung

Die Bibliothek kann via nuget installier werden:

```dotnet add package Esstra.Hit.Client```

Die Klasse `Esstra.Hit.Client.HitClient` stellt alle Funktionen für den Zugriff auf das HIT System zur Verfügung. Idealerweise wird diese Klasse mittels Dependency Injection angefragt. Für die [Dependency Injection Komponenten aus dem Microsoft Extensions Framework](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage), liefert die Bibliothek entsprechende Funktionen mit:

```csharp
var services = new ServiceCollection()
    .AddScoped<IConfiguration>(_ => configuration)
    .AddHitClient((options, configuration) =>
    {
        options.BaseAddress = HitBaseAddresses.Test;
    })
    .BuildServiceProvider();
```

Die Funktion `AddHitClient` fügt die Klasse `HitClient` und andere Abhängigkeiten zur Service Collection hinzu. Optional können noch bestimmte Konfigurationsparameter gesetzt werden, wie in dem Beispiel oben.

Der Client ist unterteilt in die einzelnen [REST-Schnittstellen des HIT-Systems](https://www.hi-tier.de/HitCom3/swagger/ui/index#/). Nachfolgend werden die einzelnen REST-Schnittstellen und ihre Implementierung in diesen Client beschrieben.

## Convert

Diese REST-Schnittstelle ist nicht implementiert.

## DataDict

Diese REST-Schnittstelle ist nicht implementiert.

## Hit

Die Schnittstelle `Hit` heißt in diesem Client "Entities". Die Operationen dieser Schnittstelle stehen dementsprechend unter `HitClient.Entities` zur Verfügung.

### `GetAsync`

**Schnittstelle**: [`GET /api/hit/{entity}`](https://www.hi-tier.de/HitCom3/swagger/ui/index#!/Hit/Hit_GetComplexHITP)

Die Methode `GetAsync` ruft Entitäten ab. `TEntity` repräsentiert dabei die Klasse, in welche die Ergebnisse deserialisiert werden sollen. Dafür stehen unter dem Namensraum `Esstra.Hit.Client.Entities` [alle verfügbaren Entitäten](https://www4.hi-tier.de/Entwicklung/Konzept/_asp/dd00001.asp) zur Verfügung, die der Datenbank bekannt sind. Um beispielsweise einen Betriebsstammsatz abzurufen, steht die Klasse `BTR_D` zur Verfügung:

```csharp
await client
    .GetAsync<BTR_D>(
        bnr: "090000000001", 
        pin: "Aaaa$900001", 
        condition: "BNR15;=;090000000001;ORDER;NAME");
```

Die Methode extrahiert den Entitätsnamen (`entity`) und die abzurufenden Spalten (`columns`), [die von dem REST-Endpunkt erwartet werden](https://www.hi-tier.de/HitCom3/swagger/ui/index#!/Hit/Hit_GetComplexHITP), aus der Klasse selber:

```csharp
[Entity("BTR_D")]
public class BTR_D
{
    [Column("ANREDE")]
    public string? ANREDE { get; set; }

    // ...
}
```

Das Attribut `Entity` enthält dabei den Namen der abzurufenden Entität und die Eigenschaften der Klasse, die mit dem `Column`-Attribut dekoriert sind, enthalten die Spaltennamen.

Dadurch ist es auch möglich, eigene Klassen zu erstellen. Auch die Verwendung von Inline-Funktionen ist hierdurch möglich:

```csharp
[Entity("BTR_D")]
public class Betriebsstammsatz
{
    [Column("BNR15")]
    [JsonPropertyName("BNR15")]
    public decimal? Betriebsnummer { get; set; }

    [Column("$ADDRPOST(BNR15;NAME/NAME)")]
    [JsonPropertyName("NAME")]
    public string? Name { get; set; }
}
```

Die Klasse kann nun durch `GetAsync` verwendet werden:

```csharp
await client
    .GetAsync<Betriebsstammsatz>(
        bnr: "090000000001", 
        pin: "Aaaa$900001", 
        condition: "BNR15;=;090000000001;ORDER;NAME");
```

[Weitere Informationen zu der Verwendung von Entitäten sind in der Dokumentation enthalten](/docs/Entities.md).

### `PostAsync`

**Schnittstelle**: [`POST /api/hit/{entity}`](https://www.hi-tier.de/HitCom3/swagger/ui/index#!/Hit/Hit_PostForEntity)

Um Entitäten anzulegen, wird die Methode `PostAsync` aufgerufen. Diese Methode nimmt eine Entität entgegen, oder eine Liste von Entitäten.

```csharp
var entity = new HT_ZUTE() {
    BNR15_HTA = 90000000001,
    BNR15_HTD = 90000000002,
    HT_PASSOG = "90102",
    HT_PASSUG = "90111",
    HT_ZUTEANZ = 10,
    HT_ZUTEDAT = DateOnly.Parse("10.09.2021"),
    HT_BEGRND = "Bestellung"
}

client.Entities.PostAsync(
    values: entity, 
    bnr: "090000000001", 
    pin: "Aaaa$900001"
);
```

## HitBatch

Diese REST-Schnittstelle ist nicht implementiert.

## HitCom

Diese REST-Schnittstelle ist nicht implementiert.

## HitRaw

Diese REST-Schnittstelle ist nicht implementiert.

## PDF

Diese REST-Schnittstelle ist nicht implementiert.

## Spezial

Diese REST-Schnittstelle ist nicht implementiert.
