Random r = new Random();
int liczba = r.Next(0, 10);
double a;
Console.WriteLine("zgadnij liczbe");
a = double.Parse(Console.ReadLine());
if (a < liczba)
{
    Console.WriteLine("Podana liczba jest za mała");
}
else if (a > liczba)
{
    Console.WriteLine("Podana liczba jest za duża");

}
else
    Console.WriteLine("Zgadłeś");
while (a != liczba)
{
    Console.WriteLine("Zgadnij liczbe");
    a = double.Parse(Console.ReadLine());
    if (a < liczba)
    {
        Console.WriteLine("Podana liczba jest za mała");
    }
    else if (a > liczba)
    {
        Console.WriteLine("Podana liczba jest za duża");

    }
    else
        Console.WriteLine("Zgadłeś");
}