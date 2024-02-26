int n1, n2, n3;

Console.WriteLine("numero1, 2 , 3");
string[] vet = Console.ReadLine().Split(" ");
n1 = int.Parse(vet[0]);
n2 = int.Parse(vet[1]);
n3 = int.Parse(vet[2]);
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine(n1);
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine(n2);
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine(n3);
}
    

