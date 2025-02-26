int age = int.Parse(Console.ReadLine());
double price = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());
double sum =0;
int money = 10;

for(int i = 1; i<=age; i++)
{if(age%2==0)
    {
        sum += 10 - 1;
        money += 10;
    }
    else
    {
        sum += toyPrice;
    }

}

if(sum>=price)
{
    Console.WriteLine($"Yes! {sum-price:F2}");
}
else
{
    Console.WriteLine($"No! {price-sum:F2}");
}
