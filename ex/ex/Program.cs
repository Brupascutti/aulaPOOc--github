int n;
n =  int.Parse(Console.ReadLine());
for (int i = 2; i <=n; i++)
{
    if (i % 2 == 0)
    {

        int quadrado = i * i;
        Console.WriteLine(quadrado);
    }
    
}

