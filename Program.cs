// See https://aka.ms/new-console-template for more information
using GeradorChavePix;

Console.WriteLine("-----------------");
Console.WriteLine("GERADOR CHAVE PIX");
Console.WriteLine("-----------------");

Console.Write("Quantidade a ser gerada de chaves: ");

var quantidadeChaves = int.Parse(Console.ReadLine());

var chavesPix = GeradorPix.GetChavesPix(quantidadeChaves);

chavesPix.ForEach(chave => Console.WriteLine(chave));
