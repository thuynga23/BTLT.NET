using System;
using System.Collections.Generic;

// Lop truu tuong PhuongTien
abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    // Phuong thuc truu tuong
    public abstract void DiChuyen();
}

// Giao dien IThongTinThem
interface IThongTinThem
{
    int TocDoToiDa();
    double MucTieuThuNhienLieu(); // Phuong thuc cho muc tieu thu nhien lieu
}

// Lop XeHoi ke thua tu PhuongTien va hien thuc giao dien IThongTinThem
class XeHoi : PhuongTien, IThongTinThem
{
    public XeHoi()
    {
        TenPhuongTien = "Xe hoi";
        LoaiNhienLieu = "Xang";
    }

    // Hien thuc phuong thuc DiChuyen
    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang dong co.");
    }

    // Hien thuc phuong thuc giao dien
    public int TocDoToiDa()
    {
        return 200; // toc do toi da 200 km/h
    }

    public double MucTieuThuNhienLieu()
    {
        return 8.5; // tieu thu 8.5 lit/100km
    }
}

// Lop XeDap ke thua tu PhuongTien va hien thuc mot phuong thuc tu giao dien IThongTinThem
class XeDap : PhuongTien, IThongTinThem
{
    public XeDap()
    {
        TenPhuongTien = "Xe dap";
        LoaiNhienLieu = "Khong co";
    }

    // Hien thuc phuong thuc DiChuyen
    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang suc nguoi.");
    }

    // Hien thuc phuong thuc giao dien
    public int TocDoToiDa()
    {
        return 25; // toc do toi da 25 km/h
    }

    // Xe dap khong tieu thu nhien lieu
    public double MucTieuThuNhienLieu()
    {
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao danh sach cac phuong tien
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>()
        {
            new XeHoi(),
            new XeDap()
        };

        // In thong tin va goi cac phuong thuc
        foreach (var pt in danhSachPhuongTien)
        {
            Console.WriteLine($"Phuong tien: {pt.TenPhuongTien}");
            Console.WriteLine($"Loai nhien lieu: {pt.LoaiNhienLieu}");
            pt.DiChuyen();

            // Kiem tra neu phuong tien hien thuc giao dien IThongTinThem
            if (pt is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");

                // Chi in muc tieu thu nhien lieu neu lon hon 0
                double nhienLieu = thongTinThem.MucTieuThuNhienLieu();
                if (nhienLieu > 0)
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {nhienLieu} lit/100km");
                }
            }

            Console.WriteLine(); // In dong trong giua cac phuong tien
        }
    }
}
