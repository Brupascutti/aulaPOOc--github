using POO;

Pessoa p1, p2;
p1 = new Pessoa();
p2 = new Pessoa();
Console.WriteLine("dados da 1 pessoa: ");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("dados da 2 pessoa: ");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade)
{
    Console.WriteLine("pessoa maiis velha: " + p1.Nome);
}
else
{
    Console.WriteLine("pessoa mais velha: "+ p2.Nome);
}




