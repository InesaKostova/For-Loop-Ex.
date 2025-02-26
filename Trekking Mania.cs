int groups = int.Parse(Console.ReadLine());
int peopleMusala = 0;
int peopleMontblanc = 0;
int peopleKilimanjaro = 0;
int peopleK2 = 0;
int peopleEverest = 0;

for(int i=1; i<=groups; i++)
{ int countPeople = int.Parse(Console.ReadLine());
    if(countPeople<=5)
    {
        peopleMusala += countPeople;
    }
    else if(countPeople<=12)
    {
        peopleMontblanc+= countPeople;
    }
    else if(countPeople<=25)
    {
     peopleKilimanjaro += countPeople;
    }
    else if(countPeople<=40)
    {
        peopleK2+= countPeople;
    }
    else if(countPeople>40)
    {
        peopleEverest+= countPeople;
    }
}
double totalPeople = peopleMusala + peopleMontblanc + peopleKilimanjaro + peopleK2 + peopleEverest;
Console.WriteLine($"{peopleMusala/totalPeople * 100:F2}%");
Console.WriteLine($"{peopleMontblanc/totalPeople * 100:F2}%");
Console.WriteLine($"{peopleKilimanjaro / totalPeople * 100:F2}%");
Console.WriteLine($"{peopleK2 / totalPeople *100:F2}%");
Console.WriteLine($"{peopleEverest / totalPeople * 100:F2}%");
