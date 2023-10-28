using Sorting;
using Searchs;
using Lists;

Console.Write("Digite o número de elementos que a lista irá conter: ");

int n = int.Parse(Console.ReadLine());
var list = List.Random(n);

var listBubble = Sort.Bubble(list);
List.ShowList(listBubble);
Console.WriteLine();

Console.Write("Digite o elemento que você deseja procurar na lista: ");
int target = int.Parse(Console.ReadLine());

int indiceLinear = Search.Linear(listBubble, target);
int tentativasLinear = Search.CatchLinearAttempts(listBubble, target);
int indiceBinario = Search.Binary(listBubble, target);
int tentativasBinario = Search.CatchBinaryAttempts(listBubble, target);
Console.WriteLine();

if (indiceLinear == -1 || indiceBinario == -1)
{
	Console.WriteLine($"O elemento {target} não está presente na lista");
}
else
{
	Console.WriteLine("Busca Linear:");
	Console.WriteLine($"O elemento {target} foi encontrado no índice {indiceLinear}");
	Console.WriteLine($"A busca linear precisou de {tentativasLinear} tentativas para encontrar o elemento {target}");
	Console.WriteLine();
	Console.WriteLine("Busca Binária:");
	Console.WriteLine($"O elemento {target} foi encontrado no índice {indiceBinario}");
	Console.WriteLine($"A busca binária precisou de {tentativasBinario} tentativas para encontrar o elemento {target}");
}