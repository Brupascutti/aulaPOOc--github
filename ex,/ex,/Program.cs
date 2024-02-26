int n;
double[] vet;
n = int.Parse(Console.ReadLine());
vet = new double[n];
string[] s = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    vet[i] = double.Parse(s[i]);
}
for (int i = 0;i < n; i++)
{
    Console.WriteLine(vet[i] + " ");
}
Double soma = 0;
for (int i = 0;i<n; i++)
{
    soma = soma + vet[i];
}
double media = soma / n;
Console.WriteLine(soma.ToString("F2"));
Console.WriteLine(media.ToString("F2"));

