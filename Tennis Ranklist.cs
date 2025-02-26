int tours = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());
double points = 0;
int countWinTour = 0;
for(int i=1; i<=tours; i++)
{
    string result = Console.ReadLine();
    if(result =="W")
    {
        points += 2000;
        countWinTour++;
    }
    else if(result=="F")
    {
        points += 1200;
    }
    else if(result=="SF")
    {
        points += 720;
    }
}
Console.WriteLine($"Final points: {startPoints + points}");
Console.WriteLine($"Average points: {Math.Floor(points / tours)}");
Console.WriteLine($"{(double)countWinTour / tours * 100:F2}%");
