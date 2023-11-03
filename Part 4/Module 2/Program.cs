
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

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

/* 
Ao fazer a coerção de int value = (int)1.5m;, o valor do float é truncado para que o resultado seja 1, o que significa que o valor após o decimal é completamente ignorado. É possível alterar o float literal para 1.999m e o resultado da coerção é o mesmo.

Ao fazer a conversão usando Convert.ToInt32(), o valor do float literal é arredondado corretamente para 2. Se você alterar o valor literal para 1.499m, ele será arredondado para baixo para 1
*/

// Unit 3

// string value = "bad";
// int result = 0;

// if(int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if(result > 0)
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Unit 4 - Challenge

// string[] values = { "12,3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string mensagem = "";
// decimal valor_num = 0;

// for(int i = 0; i < values.Length; i++)
// {
//     if(decimal.TryParse(values[i], out valor_num)){
//         total += valor_num;
//     }
//     else
//     {
//         mensagem += values[i];
//     }
// }

// Console.WriteLine("Message: " + mensagem);
// Console.WriteLine("Total: " + total);

// Unit 6 - Challenge

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
// int result1 = value1 / (int)value2;
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal) value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

