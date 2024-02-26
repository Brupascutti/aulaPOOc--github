
double idade, soma, media;
int cont;
idade = double.Parse(Console.ReadLine());
soma = 0.0;
cont = 0;
while(idade >= 0)
{
    soma += idade;
    cont += 1;
    idade = double.Parse(Console.ReadLine());
}
media = soma / cont;
Console.WriteLine(media.ToString("f2"));




