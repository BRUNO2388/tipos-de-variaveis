// Declare variáveis e inicialize com zero.
var num1 = 0; var num2 = 0;

// Exibir título como o ap da calculadora do console C#.
Console.WriteLine("Calculadora em C#\r");
Console.WriteLine("------------------------\n");

// Peça ao usuário para digitar o primeiro número.
Console.WriteLine("Digite um número e pressione Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Peça ao usuário para digitar o segundo número.
Console.WriteLine("Digite outro número e, em seguida,aperte Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Peça ao usuário para escolher uma opção
Console.Write    ("****************************\n");
Console.WriteLine("Escolha uma opção  a seguir:");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtracão");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.Write    ("****************************\n");
Console.Write("Sua opção? ");


// Use uma instrução switch para fazer as contas.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($" resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($" resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($" resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($" resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}
// Aguarde a resposta do usuário antes de fechar.
Console.Write("Pressione qualquer tecla para fechar a Calculadora...");
Console.ReadKey();