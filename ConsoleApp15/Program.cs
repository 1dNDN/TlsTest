using System;
using System.Net.Http;

var client = new HttpClient();
var text = client.GetStringAsync("https://google.com").Result;
Console.WriteLine($"Got {text.Length} characters");
