using System;

// Lop truu tuong Product
public abstract class Product
{
    public string TenSanPham { get; set; }
    public decimal Gia { get; set; }
    public int SoLuongTonKho { get; set; }

    public Product(string tenSanPham, decimal gia, int soLuongTonKho)
    {
        TenSanPham = tenSanPham;
        Gia = gia;
        SoLuongTonKho = soLuongTonKho;
    }

    // Phuong thuc truu tuong
    public abstract void HienThiThongTinSanPham();

    // Phuong thuc ap dung giam gia
    public void ApDungGiamGia(decimal phanTram)
    {
        Gia -= Gia * (phanTram / 100);
    }
}

// Giao dien ISellable
public interface ISellable
{
    void BanSanPham(int soLuong);
    bool KiemTraTonKho();
}

// Lop con MobilePhone ke thua tu Product va trien khai ISellable
public class MobilePhone : Product, ISellable
{
    public string ThuongHieu { get; set; }
    public string Model { get; set; }

    public MobilePhone(string tenSanPham, decimal gia, int soLuongTonKho, string thuongHieu, string model)
        : base(tenSanPham, gia, soLuongTonKho)
    {
        ThuongHieu = thuongHieu;
        Model = model;
    }

    public override void HienThiThongTinSanPham()
    {
        Console.WriteLine($"Dien thoai: {TenSanPham}, Thuong hieu: {ThuongHieu}, Model: {Model}, Gia: {Gia}, Ton kho: {SoLuongTonKho}");
    }

    public void BanSanPham(int soLuong)
    {
        if (soLuong <= SoLuongTonKho)
        {
            SoLuongTonKho -= soLuong;
            Console.WriteLine($"Da ban {soLuong} san pham.");
        }
        else
        {
            Console.WriteLine("Khong du hang trong kho.");
        }
    }

    public bool KiemTraTonKho()
    {
        return SoLuongTonKho > 0;
    }
}

// Lop con Laptop ke thua tu Product va trien khai ISellable
public class Laptop : Product, ISellable
{
    public string CPU { get; set; }
    public int RAM { get; set; }

    public Laptop(string tenSanPham, decimal gia, int soLuongTonKho, string cpu, int ram)
        : base(tenSanPham, gia, soLuongTonKho)
    {
        CPU = cpu;
        RAM = ram;
    }

    public override void HienThiThongTinSanPham()
    {
        Console.WriteLine($"Laptop: {TenSanPham}, CPU: {CPU}, RAM: {RAM}GB, Gia: {Gia}, Ton kho: {SoLuongTonKho}");
    }

    public void BanSanPham(int soLuong)
    {
        if (soLuong <= SoLuongTonKho)
        {
            SoLuongTonKho -= soLuong;
            Console.WriteLine($"Da ban {soLuong} san pham.");
        }
        else
        {
            Console.WriteLine("Khong du hang trong kho.");
        }
    }

    public bool KiemTraTonKho()
    {
        return SoLuongTonKho > 0;
    }
}

// Lop con Accessory ke thua tu Product va trien khai ISellable
public class Accessory : Product, ISellable
{
    public string LoaiPhuKien { get; set; }

    public Accessory(string tenSanPham, decimal gia, int soLuongTonKho, string loaiPhuKien)
        : base(tenSanPham, gia, soLuongTonKho)
    {
        LoaiPhuKien = loaiPhuKien;
    }

    public override void HienThiThongTinSanPham()
    {
        Console.WriteLine($"Phu kien: {TenSanPham}, Loai: {LoaiPhuKien}, Gia: {Gia}, Ton kho: {SoLuongTonKho}");
    }

    public void BanSanPham(int soLuong)
    {
        if (soLuong <= SoLuongTonKho)
        {
            SoLuongTonKho -= soLuong;
            Console.WriteLine($"Da ban {soLuong} san pham.");
        }
        else
        {
            Console.WriteLine("Khong du hang trong kho.");
        }
    }

    public bool KiemTraTonKho()
    {
        return SoLuongTonKho > 0;
    }
}

// Chuong trinh chinh
class Program
{
    static void Main(string[] args)
    {
        // Khoi tao cac doi tuong
        MobilePhone dienThoai = new MobilePhone("iPhone", 25000000, 10, "Apple", "iPhone 14");
        Laptop mayTinhXachTay = new Laptop("MacBook Pro", 40000000, 5, "Intel i9", 16);
        Accessory phuKien = new Accessory("Sac du phong", 500000, 20, "Pin du phong");

        // Hien thi thong tin san pham
        dienThoai.HienThiThongTinSanPham();
        mayTinhXachTay.HienThiThongTinSanPham();
        phuKien.HienThiThongTinSanPham();

        // Ban san pham va kiem tra ton kho
        dienThoai.BanSanPham(3);
        mayTinhXachTay.BanSanPham(2);
        phuKien.BanSanPham(5);

        // Kiem tra ton kho
        Console.WriteLine(dienThoai.KiemTraTonKho() ? "Dien thoai con hang." : "Dien thoai het hang.");
        Console.WriteLine(mayTinhXachTay.KiemTraTonKho() ? "Laptop con hang." : "Laptop het hang.");
        Console.WriteLine(phuKien.KiemTraTonKho() ? "Phu kien con hang." : "Phu kien het hang.");

        // Ap dung giam gia
        dienThoai.ApDungGiamGia(10);
        mayTinhXachTay.ApDungGiamGia(15);
        phuKien.ApDungGiamGia(5);

        // Hien thi gia sau khi giam gia
        Console.WriteLine("Thong tin san pham sau khi giam gia:");
        dienThoai.HienThiThongTinSanPham();
        mayTinhXachTay.HienThiThongTinSanPham();
        phuKien.HienThiThongTinSanPham();
    }
}
