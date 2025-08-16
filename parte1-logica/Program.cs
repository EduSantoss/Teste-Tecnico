static string InverterString(string texto)
{
    char[] caracteres = texto.ToCharArray();
    Array.Reverse(caracteres);
    return new string(caracteres);
}

Console.WriteLine("-----------------------------------");
Console.WriteLine("Realizando parte 1...");
Console.WriteLine("-----------------------------------");

Console.WriteLine("Digite uma palavra ou frase: ");
string entrada = Console.ReadLine()!;

string invertida = InverterString(entrada!);
Console.WriteLine("String invertida: " + invertida);
Console.WriteLine("-----------------------------------");

