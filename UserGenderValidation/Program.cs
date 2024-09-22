// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal valida tema sugu (m/f)
//Rakendus palub kasutajal sisestada tema perekonnanime
//Lähtudes kasutaja valikust, tervitab rakendus kasutajat järgmiselt
//"Welcome, Mr. [Kasutaja perekonnanimi]" / "Welcome",Ms. [Kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please enter your name");

string userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms, {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

