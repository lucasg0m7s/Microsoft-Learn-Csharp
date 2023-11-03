// Unit 2

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
//----------------------------------------------

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");
//----------------------------------------------

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

//----------------------------------------------

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

//----------------------------------------------

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

//----------------------------------------------

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

//----------------------------------------------

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

/* IMPORTANTE
 A classe Convert é melhor para converter números fracionários em números inteiros (int) porque os arredonda da maneira esperada 
 */

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

/* 
Ao fazer a coerção de int value = (int)1.5m;, o valor do float é truncado para que o resultado seja 1, o que significa que o valor após o decimal é completamente ignorado. É possível alterar o float literal para 1.999m e o resultado da coerção é o mesmo.

Ao fazer a conversão usando Convert.ToInt32(), o valor do float literal é arredondado corretamente para 2. Se você alterar o valor literal para 1.499m, ele será arredondado para baixo para 1
*/