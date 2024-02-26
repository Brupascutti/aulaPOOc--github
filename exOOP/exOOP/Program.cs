
using exOOP;
using System.Globalization;

Retangulo R = new Retangulo();

Console.WriteLine("coloque a largura do retangulo: ");
R.Largura = double.Parse(Console.ReadLine());
Console.WriteLine("coloque a Altura do retangulo: ");
R.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Area= " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("perimetro= " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal= " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
