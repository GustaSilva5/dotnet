# Estudo de C# com Exemplos de Naruto

Este repositório contém exemplos de código em C# aplicando conceitos fundamentais de programação com base no universo de Naruto. O objetivo deste repositório é tornar o aprendizado de C# mais divertido e intuitivo, utilizando personagens e situações do anime Naruto.

## Conteúdo

1. **Variáveis**  
   - Definindo variáveis para representar personagens e suas características.

2. **Funções (Métodos)**  
   - Criando funções para realizar ações como jutsus e saudação.

3. **Condicionais**  
   - Usando **if**, **else** e **else if** para tomar decisões baseadas em diferentes condições.

4. **Laços de Repetição (Looping)**  
   - Utilizando **while** e **for** para repetir ações, como o treinamento de Naruto.

## Estrutura do Repositório

O código está organizado em arquivos C# simples, com explicações para cada conceito de programação.

- **`Variaveis.cs`** - Exemplo de como declarar variáveis no C# usando os personagens de Naruto.
- **`Funcoes.cs`** - Funções para realizar ações como jutsus e interações.
- **`Condicionais.cs`** - Exemplos de condicionais para determinar o status de Naruto.
- **`Repeticoes.cs`** - Exemplos de laços de repetição para simular treinamentos.

## Exemplo de Código

Aqui está um exemplo de como o código é estruturado:

```csharp
using System;

public class NarutoStudy
{
    public static void Main(string[] args)
    {
        int narutoAge = 16;
        string narutoName = "Naruto Uzumaki";
        bool isHokage = false;

        // Exemplo de Condicional
        if (isHokage)
        {
            Console.WriteLine($"{narutoName} é o Hokage!");
        }
        else
        {
            Console.WriteLine($"{narutoName} ainda não é Hokage, mas vai ser!");
        }

        // Exemplo de Laço de Repetição
        int narutoLevel = 1;
        while (narutoLevel < 5)
        {
            Console.WriteLine($"{narutoName} está no nível {narutoLevel}.");
            narutoLevel++;
        }
        Console.WriteLine($"{narutoName} alcançou o nível Hokage!");
    }
}
