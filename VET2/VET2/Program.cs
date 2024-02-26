int N;
N = int.Parse(Console.ReadLine());

string[] nomes= new string[N];
int[] idade= new int[N];
double[] altura= new double[N];

//leitura dos dados
for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(" ");
    nomes[i] = s[0];
    idade[i] = int.Parse(s[1]);
    altura[i] = double.Parse(s[2]);
}
//calculo da altura
double soma = 0 ;
for(int i = 0; i < N; i++)
{
    soma = soma + altura[i];
}
double media = soma / N;
Console.WriteLine("altura media: " + media.ToString("f1"));
// porcentagem
int cont = 0;
for (int i = 0;i < N; i++)
{
    if (idade[i] < 16 )
    {
        cont++;
    }
}
double porcentagem = (double)cont / N * 100;
Console.WriteLine("pessoas com menos de 16 anos: " + porcentagem.ToString("f1") + "%");
