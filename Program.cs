Console.Write("Nhap quang duong (km): ");
decimal distance = Convert.ToDecimal(Console.ReadLine());
decimal fare = CalculateFare(distance);
Console.WriteLine(fare);
decimal CalculateFare(decimal distance)
{
    const decimal rate1 = 14000m;
    const decimal rate2 = 11000m;
    const decimal firstLimit = 30m;
    if (distance <= firstLimit)
    {
        return distance * rate1;
    }
    else
    {
        decimal fare = firstLimit * rate1;
        fare += (distance - firstLimit) * rate2;
        return fare;
    }
}