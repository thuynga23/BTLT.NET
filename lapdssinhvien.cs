using System;
using System.Collections.Generic;
using System.Linq;

public class SinhVien
{
    // Thuộc tính của lớp SinhVien
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }

    // Phương thức nhập thông tin sinh viên từ bàn phím
    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap ma so sinh vien (MSSV): ");
        MSSV = Console.ReadLine();

        Console.Write("Nhap diem trung binh: ");
        DiemTrungBinh = double.Parse(Console.ReadLine());
    }

    // Phương thức hiển thị thông tin sinh viên
    public void HienThiThongTin()
    {
        Console.WriteLine($"Ho ten: {HoTen}, MSSV: {MSSV}, Diem trung binh: {DiemTrungBinh}");
    }
}

public class DanhSachSinhVien
{
    // Thuộc tính là danh sách các sinh viên
    private List<SinhVien> danhSach = new List<SinhVien>();

    // Phương thức thêm sinh viên vào danh sách
    public void ThemSinhVien(SinhVien sv)
    {
        danhSach.Add(sv);
    }

    // Phương thức hiển thị danh sách sinh viên
    public void HienThiDanhSach()
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien trong.");
        }
        foreach (var sv in danhSach)
        {
            sv.HienThiThongTin();
        }
    }

    // Phương thức tìm sinh viên theo MSSV
    public SinhVien TimSinhVienTheoMSSV(string mssv)
    {
        return danhSach.FirstOrDefault(sv => sv.MSSV == mssv);
    }

    // Phương thức tìm sinh viên có điểm trung bình cao nhất
    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        if (danhSach.Count == 0)
            return null;
        return danhSach.OrderByDescending(sv => sv.DiemTrungBinh).FirstOrDefault();
    }
}

public class Program
{
    public static void Main()
    {
        DanhSachSinhVien danhSach = new DanhSachSinhVien();

        // Nhập thông tin cho ít nhất 3 sinh viên
        int soLuongSinhVien = 3;
        for (int i = 0; i < soLuongSinhVien; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            danhSach.ThemSinhVien(sv);
        }

        // Hiển thị danh sách sinh viên
        Console.WriteLine("\nDanh sach sinh vien da nhap:");
        danhSach.HienThiDanhSach();

        // Tìm và hiển thị sinh viên có điểm trung bình cao nhất
        SinhVien svCaoNhat = danhSach.TinhDiemTrungBinhCaoNhat();
        if (svCaoNhat != null)
        {
            Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
            svCaoNhat.HienThiThongTin();
        }

        // Tìm kiếm sinh viên theo MSSV
        Console.Write("\nNhap MSSV de tim kiem sinh vien: ");
        string mssvTimKiem = Console.ReadLine();
        SinhVien svTimDuoc = danhSach.TimSinhVienTheoMSSV(mssvTimKiem);
        if (svTimDuoc != null)
        {
            Console.WriteLine("\nThong tin sinh vien tim thay:");
            svTimDuoc.HienThiThongTin();
        }
        else
        {
            Console.WriteLine("\nKhong tim thay sinh vien voi MSSV da nhap.");
        }
    }
}
