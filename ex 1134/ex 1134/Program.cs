int alcool, gasolina, disel, num;
Console.WriteLine("alcool= 1  gasolina=2  disel=3  4=FIM");
num = int.Parse(Console.ReadLine());
alcool = 1;
gasolina = 2;
disel = 3;
while (num != 4){
    if (num == 1)
    {
        alcool = +1;
    }if (num == 2)
    {
        gasolina = +1;
    }if (num == 3)
    {
        disel = +1;
    }else
    {
        Console.WriteLine("numero invalido");
    }
    Console.WriteLine("alcool= 1  gasolina=2  disel=3  4=FIM");
}
Console.WriteLine("disel=  " + disel + "gasolina= " + gasolina + "alcool= " + alcool);


