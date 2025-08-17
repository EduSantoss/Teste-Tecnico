static string InverterString(string texto)
{
    char[] caracteres = new char[texto.Length];
    for (int i = 0; i < texto.Length; i++)
    {
        caracteres[i] = texto[texto.Length - 1 - i];
    }
    return new string(caracteres);
}
Console.WriteLine("---------------------");
Console.WriteLine("Realizando parte 1...");
Console.WriteLine("---------------------");

Console.Write("Digite uma palavra ou frase: ");
string entrada = Console.ReadLine()!;
if (string.IsNullOrWhiteSpace(entrada))
{
    Console.WriteLine("Digite um texto válido, não vazio !!");
}
else
{
   string invertida = InverterString(entrada!);
   Console.WriteLine("String invertida: " + invertida);
}

Console.WriteLine("-----------------------------------");

