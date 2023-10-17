//---------------Unit 2---------------------//

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

// string pangram = "The quick brown fox jumps over the lazy dog.";

// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));
//---------------Unit 3 ---------------------//

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 100 ? 100 : 50)}");

//---------------Unit 4 ---------------------//
// Random coinChance = new Random();
// int chance = coinChance.Next(1,3);
// Console.WriteLine($"Result: {(chance == 2 ? "heads" : "tails")}");

//---------------Unit 6 ---------------------//
string permission = "Manager";
int level = 00;

if(!permission.Contains("Admin") && !permission.Contains("Manager")){
    Console.WriteLine("You do not have sufficient privileges.");
}
else if(permission.Contains("Manager") && level < 20){
    Console.WriteLine("You do not have sufficient privileges.");
}
else if(permission.Contains("Manager") && level >= 20){
    Console.WriteLine("Contact an Admin for access.");
}
else if(permission.Contains("Admin") && level <= 55){
        Console.WriteLine("Welcome, Admin user.");
}
else{
    Console.WriteLine("Welcome, Super Admin user.");
}
// Resposta da Microsoft //
// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }