using Esstra.Hit.Client;
using Esstra.Hit.Client.Annotations;
using Esstra.Hit.Client.Entities;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System.Text.Json.Serialization;

var configuration = new ConfigurationBuilder()
    .AddCommandLine(args)
    .Build();

var bnr = "090000000001";
var pin = "Aaaa$900001";

var client = new ServiceCollection()
    .AddScoped<IConfiguration>(_ => configuration)
    .AddHitClient((options, configuration) =>
    {
        options.BaseAddress = HitBaseAddresses.Test;
    })
    .BuildServiceProvider()
    .GetRequiredService<HitClient>();

var entities = await client
    .Entities
    .GetAsync<Betriebsstammsatz>(bnr, pin: pin, subcodes: "R10", condition: $"BNR15;=;{bnr};ORDER;NAME")
    .ConfigureAwait(false);

var entity = entities.Items.Single();

Console.WriteLine($"Betriebsnummer: {entity.Betriebsnummer}");
Console.WriteLine($"Name: {entity.Adresse.Single().NAME}");

Console.WriteLine("Done");
Console.ReadLine();

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