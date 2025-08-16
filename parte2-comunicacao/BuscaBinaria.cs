static int BuscaBinaria(int[] array, int valor)
{
    int inicio = 0;
    int fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (array[meio] == valor)
            return meio; // ou seja, valor encontrado

        if (valor < array[meio])
            fim = meio - 1; // Procura na metade esquerda, a cada nova divisão
        else
            inicio = meio + 1; // Procura na metade direita, a cada nova divisão
    }

    return -1; // Não faz parte da lista, ou seja, não foi encontrado
}

int[] numeros = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };
int valorProcurado = 23;

int resultado = BuscaBinaria(numeros, valorProcurado);

if (resultado != -1)
    Console.WriteLine($"Valor encontrado na posição {resultado}");
else
    Console.WriteLine("Valor não encontrado");


