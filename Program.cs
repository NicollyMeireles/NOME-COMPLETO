string nome, sobrenome;
Console.WriteLine ("digite seu nome _____________");
nome = Console.ReadLine()!;

Console.Write("digite seu sobrenome________________");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"nome completo: {nome} {sobrenome}");
Console.WriteLine($"nome de catálogo: {sobrenome.ToUpper()}, {nome}");
