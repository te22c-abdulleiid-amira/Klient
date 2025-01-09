﻿using System.IO;

HttpClient client = new();

client.BaseAddress = new("https://digi-api.com/api/v1/digimon");

HttpResponseMessage response = client.GetAsync("digimon/angemon").Result; 

string angemon = response.Content.ReadAsStringAsync().Result;

digimon p = JsonSerializer.Deserialize<digimon>(response.Content.ReadAsStringAsync().Result);

// File.WriteAllText("angemon.json", angemon);

Console.ReadLine();

