//slump

 //Random generator = new Random();

 //int slumptal = generator.Next(100);

 //Console.WriteLine(slumptal);


// while-loop


//int tal = 100;

//while (tal > 0)
//{
//    Console.WriteLine(tal);
 //}

Console.WriteLine("Tja välkommen till Nti fightclub");
Console.WriteLine("Sus vs nya mattanter");

int sushp = 100;
int mattanterhp = 100;
String heroname = "sus";
String  villianname = "mattanter";

Random generator = new Random();

while (sushp > 0 && mattanterhp > 0)
{
Console.WriteLine("\n------ ==== Ny Runda ==== ------");
Console.WriteLine($"{heroname}: {sushp} {villianname}: {mattanterhp}\n");

int susskada = generator.Next(20);
mattanterhp -= susskada;
mattanterhp = Math.Max(0, mattanterhp);
Console.WriteLine($"{heroname} gör {susskada} skada på {villianname}");



int mattanterskada = generator.Next(20);
sushp -= mattanterskada;
sushp = Math.Max(0, sushp);
Console.WriteLine($"{villianname} gör {mattanterskada} skada på {heroname}");

Console.WriteLine("tryck på valfri kanpp för att fortsätta");
Console.ReadKey();

}
Console.WriteLine("--------Matkriget är över--------");

if (sushp == 0 && mattanterhp == 0)
{
  Console.WriteLine("De blev ingen vinare. Men sus är alltid den bästa matskaparen");  
}
else if (sushp == 0)
{
 Console.WriteLine($"{villianname} Kanske Vann kriget denna gång men sus kommer alltid tillbaka starkare");   
}
else if (mattanterhp == 0)
{
Console.WriteLine($"{heroname} Sus vann utan ens att försöka");
}





Console.WriteLine("tryck på valfri kanpp för att fortsätta");
Console.ReadLine();

