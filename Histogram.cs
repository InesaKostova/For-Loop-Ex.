int n = int.Parse(Console.ReadLine());
double countP1 = 0;
double countP2 = 0;
double countP3 = 0;
double countP4 = 0;
double countP5 = 0;

for(int i=1; i<=n;i++)
{
    int number = int.Parse(Console.ReadLine());
    if(number<200)
    {
        countP1++;
    }
    else if(number<400)
    {
        countP2++;
    }
    else if( number<600)
    {
        countP3++;
    }
    else if(number<800)
    {
        countP4++;
    }
    else if(number>=800)
    {
        countP5++;
    }
}
Console.WriteLine($"{countP1/n * 100:F2}%");
Console.WriteLine($"{countP2 / n * 100:F2}%");
Console.WriteLine($"{countP3 / n * 100:F2}%");
Console.WriteLine($"{countP4 / n * 100:F2}%");
Console.WriteLine($"{countP5 / n * 100:F2}%");
