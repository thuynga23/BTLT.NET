using System;
using System.Collections.Generic;

// Lop cha: San pham
class Product
{
    public string TenSanPham { get; set; }
    public decimal Gia { get; set; }
    public string MoTa { get; set; }
    public int SoLuong { get; set; }

    public Product(string tenSanPham, decimal gia, string moTa, int soLuong)
    {
        TenSanPham = tenSanPham;
        Gia = gia;
        MoTa = moTa;
        SoLuong = soLuong;
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"San pham: {TenSanPham}, Gia: {Gia}, Mo ta: {MoTa}, So luong: {SoLuong}");
    }
}

// Lop con: Dien tu
class Electronic : Product
{
    public int BaoHanh { get; set; } // Thang bao hanh

    public Electronic(string tenSanPham, decimal gia, string moTa, int soLuong, int baoHanh)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        BaoHanh = baoHanh;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Bao hanh: {BaoHanh} thang");
    }
}

// Lop con: Quan ao
class Clothing : Product
{
    public string KichThuoc { get; set; }
    public string MauSac { get; set; }

    public Clothing(string tenSanPham, decimal gia, string moTa, int soLuong, string kichThuoc, string mauSac)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        KichThuoc = kichThuoc;
        MauSac = mauSac;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Kich thuoc: {KichThuoc}, Mau sac: {MauSac}");
    }
}

// Lop con: Thuc pham
class Food : Product
{
    public DateTime NgayHetHan { get; set; }

    public Food(string tenSanPham, decimal gia, string moTa, int soLuong, DateTime ngayHetHan)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        NgayHetHan = ngayHetHan;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Ngay het han: {NgayHetHan.ToShortDateString()}");
    }
}

// Lop Gio hang
class ShoppingCart
{
    private List<Product> danhSachSanPham;

    public ShoppingCart()
    {
        danhSachSanPham = new List<Product>();
    }

    public void ThemSanPham(Product sanPham)
    {
        danhSachSanPham.Add(sanPham);
        Console.WriteLine($"Da them san pham: {sanPham.TenSanPham}");
    }

    public void XoaSanPham(Product sanPham)
    {
        danhSachSanPham.Remove(sanPham);
        Console.WriteLine($"Da xoa san pham: {sanPham.TenSanPham}");
    }

    public void HienThiGioHang()
    {
        Console.WriteLine("Cac san pham trong gio hang:");
        foreach (var sanPham in danhSachSanPham)
        {
            sanPham.HienThiThongTin();
        }
    }

    public decimal TinhTongGiaTri()
    {
        decimal tongGia = 0;
        foreach (var sanPham in danhSachSanPham)
        {
            tongGia += sanPham.Gia * sanPham.SoLuong;
        }
        return tongGia;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao cac san pham mau
        var dienThoai = new Electronic("Dien thoai", 5000000, "Dien thoai thong minh", 2, 12);
        var aoThun = new Clothing("Ao thun", 150000, "Ao thun cotton", 3, "L", "Do");
        var banhMi = new Food("Banh mi", 20000, "Banh mi tuoi", 10, DateTime.Now.AddDays(5));

        // Tao gio hang
        var gioHang = new ShoppingCart();

        // Them san pham vao gio hang
        gioHang.ThemSanPham(dienThoai);
        gioHang.ThemSanPham(aoThun);
        gioHang.ThemSanPham(banhMi);

        // Hien thi cac san pham trong gio hang
        gioHang.HienThiGioHang();

        // Tinh tong gia tri don hang
        decimal tongGiaTri = gioHang.TinhTongGiaTri();
        Console.WriteLine($"Tong gia tri don hang: {tongGiaTri} VND");

        Console.ReadLine();
    }
}
