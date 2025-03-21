Console.Write("Nhap so nguoi: ");
decimal so_nguoi = decimal.Parse(Console.ReadLine());
decimal so_tien = 0m;
string check = "";
DayOfWeek today = DateTime.Now.DayOfWeek;

if (today >= DayOfWeek.Monday && today <= DayOfWeek.Friday)
{
    check = "trong tuan";
}
else if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
{
    check = "cuoi tuan";
}

switch (check)
{
    case "trong tuan":
        so_tien = 30000m * so_nguoi;
        break;
    case "cuoi tuan":
        so_tien = 50000m * so_nguoi;
        break;
}

if (so_nguoi <= 0) /* tranh truong hop so nguoi la am */
{
    throw new ArgumentOutOfRangeException("So nguoi khong hop le");
}
Console.WriteLine($"So tien: {so_tien}");