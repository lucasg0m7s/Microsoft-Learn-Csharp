
/* Unit 2

A instrução 'do while' faz com que o bloco de codigo seja executado obrigatoriamente uma vez, visto que a expressão boleana é avaliada apenas no final da instrução

do
{
    Esse código é executado pelo menos uma vez
} while (true)

Se a expressão booleana retornar true, o bloco de código será executado novamente.

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
}while (current != 7);


No caso do while, a expressão boleana é avaliada logo no começo da instrução 

Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if(current >= 8) 
    {
        continue;
    }
    
    Console.WriteLine(current);
}while (current != 7);

*****CHALLENGES******

Challenge Unit 3

int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();

int damage = 0;

do{
    damage = random.Next(1, 11);
    monsterHealth -= damage;

    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.\n");

    if(monsterHealth <= 0)
    {
        Console.WriteLine("Hero Wins");
        continue;
    }
    else
    {
        damage = random.Next(1, 11);
        heroHealth -= damage;

        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.\n");

        if(heroHealth <= 0)
        {
            Console.WriteLine("Monster Wins!");
        }
    }
}while(monsterHealth > 0 && heroHealth > 0);

Unit 5 - Code project 1

string? valorEntrada;
int valorNumerico = 0;
bool numeroValido = false;

Console.WriteLine("Informe um valor entre 5 a 10: ");
do
{
    valorEntrada = Console.ReadLine();
    numeroValido = int.TryParse(valorEntrada, out valorNumerico);

    if(numeroValido == false)
    {
       Console.WriteLine("Você não inseriu um número válido. Tente novamente.") ;

       continue;
    }
    else if(valorNumerico < 5 || valorNumerico > 10)
    {
        Console.WriteLine($"Você inseriu {valorNumerico}. Por favor, insira um número entre 5 e 10.");

        numeroValido = false;
    }
    else
    {
        numeroValido = true;
    }
}while(numeroValido == false);

Console.WriteLine($"Seu valor de entrada ({valorNumerico}) foi aceito.");

Unit 5 - Code project 2

string? userInput;
bool validInput = false;

Console.WriteLine("Funções:\n\nAdministrador\nGerente\nUsuario\n");
Console.WriteLine("Informe uma das três funções: ");

do{
    userInput = Console.ReadLine().Trim().ToLower();

    if(userInput == "administrador" || userInput == "gerente" || userInput == "usuario")
    {
        validInput = true;
    }
    else
    {
        Console.WriteLine($"A função que você digitou, '{userInput}' não é válida. Tente Novamente.");
    }
}while(validInput == false);

Console.WriteLine($"Seu valor de entrada ({userInput}) foi aceito.");

*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0; 

foreach(string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    Console.WriteLine(myString.Remove(periodLocation));

    // while(periodLocation != -1){
    //     Console.WriteLine(myString.Remove(periodLocation));
    //     periodLocation = myString.IndexOf(".");
    // }
}

