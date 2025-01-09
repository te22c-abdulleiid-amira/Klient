using System.IO;
using System.Text.Json;

HttpClient client = new();

client.BaseAddress = new("https://digi-api.com/api/v1/digimon");

HttpResponseMessage response = client.GetAsync("digimon/angemon").Result; 

string angemon = response.Content.ReadAsStringAsync().Result;

digimon d = JsonSerializer.Deserialize<digimon>(response.Content.ReadAsStringAsync().Result);

Console.WriteLine(d.name);
Console.WriteLine(d.id);

// File.WriteAllText("angemon.json", angemon);

Console.ReadLine();

