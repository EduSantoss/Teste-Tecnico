# Busca Binária

## O que é

A busca binária é um algoritmo de busca que encontra a posição de um elemento dentro de um array ordenado. <br>
Ao invés de procurar elemento por elemento (como na busca linear), ela divide repetidamente a lista ao meio, descartando metade dos elementos a cada passo.

## Utilidade

Rapidez: A busca binária tem complexidade O(log n), muito mais rápida que a busca linear O(n) para listas grandes.

Eficiência: Reduz drasticamente o número de comparações necessárias.

Base para outros algoritmos: É usada em estruturas como árvores de busca, banco de dados, algoritmos de ordenação e sistemas de busca.

## Quando usar

Quando a lista ou array já está ordenada (em ordem crescente ou decrescente).

Quando o conjunto de dados é grande e o custo de uma busca linear seria alto.

Quando você precisa de múltiplas buscas no mesmo conjunto — ordenar uma vez e usar busca binária várias vezes é mais eficiente.

## Como funciona (passo a passo)

Definir limites: um índice inicial (inicio) e um final (fim).

Encontrar o meio: calcular (inicio + fim) / 2.

## Comparar:

Se o elemento do meio é o que você procura, retorna a posição.

Se o valor procurado é menor, ajustar o fim para meio - 1.

Se for maior, ajustar o início para meio + 1.

Repetir até encontrar o elemento ou até inicio ultrapassar fim (significa que não existe na lista).

## Vantagens

Muito rápida para grandes volumes de dados ordenados.

Fácil de implementar iterativamente ou recursivamente.

## Desvantagens

Só funciona com dados ordenados.

Em dados pequenos, a vantagem sobre a busca linear é menor.

### Referências

AUGUSTO GALEGO. Binary Search em 5 minutos. Youtube, 18 de out. 2024: https://youtu.be/zSyV0VaTF3k?si=EsTKw2KNMzJyqFVd

MILLER, Brad. RANUM, David. A busca binária. In:i Resolução de problemas com algoritmos e estruturas de dados usando Python. Traduzido por: Andrew Toshiaki Nakayama Kurauchi, Carlos Eduardo Leão Elmadjian, Carlos Hitoshi Morimoto e José Coelho de Pina. São Paulo: IME-USP, 2019. Disponínel em: https://panda.ime.usp.br/panda/static/pythonds_pt/index.html# . Acesso em: 15 de Agosto. 

