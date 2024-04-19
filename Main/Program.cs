var fruits = new List<string>();

fruits.Add("cereja");
fruits.Add("abacaxi");
fruits.Add("maca");
fruits.Add("laranja");
fruits.Add("coco");
fruits.Add("banana");

// 1 - primeiro elemento
Console.WriteLine(fruits.First());
Console.WriteLine(fruits.FirstOrDefault("Nao encontrei."));

// 2 - verificar se um elemento existe
Console.WriteLine(fruits.Any(x => x == ("banana")));

// 3 - verificar se todos items sao de um tipo
Console.WriteLine(fruits.All(x => x == ("cereja")));

// 4 - contar
Console.WriteLine(fruits.Count);

// 5 - elementAt - indice
Console.WriteLine(fruits.ElementAt(5));

// 6 - Take
foreach (var fruit in fruits.Take(3))
{
    Console.WriteLine(fruit);
}

// 7 - Where
foreach (var fruit in fruits.Where(x => x == "coco" || x == "laranja"))
{
    Console.WriteLine(fruit);
}

// 8 - Single sempre 1 elemento e se tiver 2 da erro
Console.WriteLine(fruits.Single(x => x == "cereja"));

// 9 - Ultimo 
Console.WriteLine(fruits.Last());

// 10 - Skip
foreach (var fruit in fruits
    .Skip(3))
Console.WriteLine(fruit);

//-----------------------------------------------

// Número da página desejada e tamanho da página
int pageNumber = 2; // Página 2
int pageSize = 10; // 10 itens por página

// Calcular o índice inicial a ser pulado
int startIndex = (pageNumber - 1) * pageSize;

// Consulta LINQ para a página desejada
var pagedItems = fruits.Skip(startIndex).Take(pageSize);

// Exibir os itens da página
foreach (var item in pagedItems)
{
    Console.WriteLine(item);
}


