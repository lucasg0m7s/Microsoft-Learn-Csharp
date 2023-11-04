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


// string value = "abc123";
// char[] valueArray = value.ToCharArray(); // Transforma em uma matriz de char em que cada elemento da matriz é um caractere da string original

// Array.Reverse(valueArray); // Inverte a ordem dos elementos

// string result = new string(valueArray); // Transforma em uma string novamente
// Console.WriteLine(result);

// --------------------------------------------------------------

//Join() => Separa cada elemento da matriz com um caractere
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(','); // Cria uma matriz do tipo string, dividindo uma string longa em strings menores
foreach (string item in items)
{
    Console.WriteLine(item);
}

Unit 5 - Challenge


string pangram = "The quick brown fox jumps over the lazy dog";

char[] pangramChar = pangram.ToCharArray();
Array.Reverse(pangramChar);

string pangramVersion2 = new string(pangramChar);
string[] pangramString = pangramVersion2.Split(" ");
Array.Reverse(pangramString);

string pangramVersion3 = String.Join(" ", pangramString);
Console.WriteLine(pangramVersion3);

Unit 7 - Challenge

*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);

for(int i = 0; i < orderIDs.Length; i++){
    if(orderIDs[i].Length != 4){
        Console.WriteLine($"{orderIDs[i]} \t- Error");
    }else{
        Console.WriteLine(orderIDs[i]);
    }
}