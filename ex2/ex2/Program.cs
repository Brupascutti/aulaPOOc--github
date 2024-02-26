using ex2;
using System.Globalization;

Funcionario F = new Funcionario();

Console.WriteLine("Nome, Salario Bruto, Imposto: ");
F.Nome = Console.ReadLine();
F.SalarioBruto= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
F.Imposto= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Funcionario: " + F);

Console.WriteLine();
Console.WriteLine("Digite a porcentagem para aumentar o salario");
double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
F.AumentarSalario(porcent);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + F);

