static int BuscaBinaria(int[] array, int valor)
{
    int inicio = 0;
    int fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (array[meio] == valor)
        {
            return meio; // ou seja, valor encontrado
        }
        if (valor < array[meio])
        {
            fim = meio - 1; // Procura na metade esquerda, a cada nova divisão
        }
        else
        {
            inicio = meio + 1; // Procura na metade direita, a cada nova divisão
        }

    }
    return -1; // Não faz parte da lista, ou seja, não foi encontrado
}

int[] numeros = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };
int valorProcurado = 45;

int resultado = BuscaBinaria(numeros, valorProcurado);

if (resultado != -1)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"Valor encontrado na posição {resultado} do array, que corresponde à {resultado + 1}° posição se contarmos de forma tradicional.");
    Console.WriteLine("-----------------------------------");
}
else
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Valor não encontrado");
    Console.WriteLine("--------------------");
}



