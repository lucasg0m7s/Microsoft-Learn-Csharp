// Unit 2
/*
string[] pallets = {"B14", "A11", "B12", "A13"};

Console.WriteLine("Sorted...");
Array.Sort(pallets); // Método usado para classificar os itens da matriz em ordem crescente, modo alfanumérico

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets); // Inverter a ordem dos itens
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Unit 3


string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2); // Limpa valores armazenados nos elementos da matriz, começando no indice 0 e limpando até o 2.
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); // Adiciona elementos na matriz
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";


foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3); // Remove elementos da matriz
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Unit 4
*/

string value = "abc123";
char[] valueArray = value.ToCharArray();