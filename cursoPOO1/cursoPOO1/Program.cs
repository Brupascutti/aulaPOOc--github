
using cursoPOO1;
using System.Globalization;

Triangulo x, y;

x= new Triangulo();
y= new Triangulo();

Console.WriteLine("escolha os lados do triangulo X:");
x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("escolha os lados do triangulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double P = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(P * ( P - x.A) * ( P - x.B ) * ( P - x.C ) );

P = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(P * ( ( P - y.A ) * ( P - y.B ) * ( P - y.C ) ) );

Console.WriteLine("area de x = " + areaX.ToString("f4"));
Console.WriteLine("area de y = " + areaY.ToString("f4"));
 if ( areaX > areaY)
{
    Console.WriteLine("mairoa area: X");
}
else
{
    Console.WriteLine("maior area: Y");
}