using System.ComponentModel.Design;

Console.WriteLine("Kérem a nevedet: ");
string nev = Console.ReadLine();
Console.WriteLine("Kérem a rendelés összegét: ");
int osszeg = int.Parse(Console.ReadLine());
bool Tvasarlo = true;
Console.WriteLine("Törzsvásárló vagy?(igen/nem)");
string valasz = Console.ReadLine();
int szalitasi = 0;
if (valasz == "nem" )
{
    Tvasarlo = false;
}

if (osszeg >= 10000 || Tvasarlo)
{
    szalitasi = 0;
}
else if (osszeg>=5000)
{
    szalitasi = 500;
}
else
{
    szalitasi = 1200;
}
int fizetendo = osszeg + szalitasi;

Console.WriteLine("================================");
Console.WriteLine($"Vásárló neve: {nev}");
Console.WriteLine($"Rendelés összege: {osszeg} ");
Console.WriteLine($"Szálítasi díj: {szalitasi} Ft");
Console.WriteLine($"fizetendő végösszeg: {fizetendo}Ft");
Console.WriteLine("================================");