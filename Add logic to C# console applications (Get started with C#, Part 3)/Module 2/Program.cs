// Unit 2 - Code blocks and variable scope 

/*
bool flag = true;
int value = 0;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");
*/

// Unit 3 - Remove code blocks from if statements

/*
string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");
*/

// Unit 4 - Complete a challenge activity using variable scope

using System.Runtime.InteropServices.Marshalling;

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
