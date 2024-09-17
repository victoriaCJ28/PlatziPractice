// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] coffeTypes;
float[] coffePrices;

coffeTypes = new string[]{ "Expresso", "Largo", "Filtrado", "Latte" };
coffePrices = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

for (int i = 0; i < coffeTypes.Length; i++)
    Console.WriteLine($"{coffeTypes[i]} coffee = $ {coffePrices[i]} usd");

