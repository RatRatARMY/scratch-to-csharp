Console.Write("Nhap so nguoi: ");
decimal so_nguoi = decimal.Parse(Console.ReadLine());
decimal so_tien;
if (so_nguoi == 1) /* di xem mot minh */
{
    so_tien = 60000;
}
else if (so_nguoi >= 2) /* di xem theo nhom */
{
    so_tien = 40000 * so_nguoi;
}
else /* truong hop so am hoac 0 */
{
    throw new ArgumentOutOfRangeException("So am hoac 0 khong hop le");
}
Console.WriteLine($"So tien: {so_tien}");