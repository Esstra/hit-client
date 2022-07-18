# Entities

Alle Entities, die der Datenbank bekannt sind, sind unter dem Namensraum `Esstra.Hit.Client.Entities` zusammengefasst. Diese Klassen wurden durch `Esstra.Hit.Client.CodeGen` generiert.

Neben den generierten Klassen, können auch eigene Klassen erstellt und genutzt werden. Dies ist hilfreich, wenn z.B. auch Funktionen genutzt werden sollen.

Eine eigene Klasse muss mit dem `EntityAttribute` dekoriert sein. Eigenschaften, die eine Spalte der Abfrage darstellen, müssen mit dem `ColumnAttribute` dekoriert werden.

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

Wenn der Name der Eigenschaft von dem Namen der Spalte abweicht, muss außerdem das `JsonPropertyNameAttribute` verwendet werden, da sonst die Deserialisierung die Eigenschaft nicht mit der Spalte zusammenbringt.

## Funktionen

[Die Verwendung von Funktionen ist auch möglich](https://www4.hi-tier.de/Entwicklung/Konzept/HITP/feink045.html). Das Beispiel oben zeigt die Verwendung einer Inline-Funktion. Auch Newline-Funktionen sind möglich. Dafür wurden neben den Datenentitäten, auch die Newline-Funktionen durch die Code-Generierung im Namensraum `Esstra.Hit.Client.Entities` erstellt. Diese Klassen beginnen mit dem Präfix `FUNC_`.

```csharp
[Entity("BTR_D")]
public class Betriebsstammsatz
{
    [Column("BNR15")]
    [JsonPropertyName("BNR15")]
    public decimal? Betriebsnummer { get; set; }

    [Column("#ADDRPOST()")]
    [JsonPropertyName("#ADDRPOST")]
    public IEnumerable<FUNC_ADDRPOST> Adresse { get; set; }
}
```

## Boolean

Während die Datenbank einen numerischen Wert zur Darstellung von Boolean-Werten zurückgibt, erwartet der Client einen Boolean-Wert. Dies ist der Fall, wenn das Format `int` entspricht und der Codeset `BOOL` ist. So wird beispielsweise [die Eigenschaft `POST_ABW` der Entität `BTR_D`](https://www4.hi-tier.de/Entwicklung/Konzept/_asp/dd00008.asp?txtParam=POST%5FABW&radTestProd=0&radHisto=0&radSuchenExakt=0) durch den Code-Generator als Boolean erstellt:

```csharp
public class BTR_D {

    // ...

    [Column("POST_ABW")]
    public bool? POST_ABW { get; set; }

    // ...
}
```
