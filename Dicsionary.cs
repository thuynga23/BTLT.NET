using System;
using System.Collections.Generic;

class LuuTruTenVaDiem
{
    static void Main()
    {
        // Khoi tao Dictionary
        Dictionary<string, int> dsHocSinh = new Dictionary<string, int>();

        // Nhap so luong hoc sinh tu nguoi dung
        Console.WriteLine("Nhap so luong hoc sinh: ");
        int soLuong = int.Parse(Console.ReadLine());

        // Nhap ten va diem cua hoc sinh vao Dictionary
        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine("Nhap ten hoc sinh thu " + (i + 1) + ": ");
            string ten = Console.ReadLine();

            Console.WriteLine("Nhap diem cua " + ten + ": ");
            int diem = int.Parse(Console.ReadLine());

            dsHocSinh.Add(ten, diem);
        }

        // In ra danh sach ten va diem
        Console.WriteLine("\nDanh sach ten va diem cua hoc sinh da nhap: ");
        foreach (KeyValuePair<string, int> hocSinh in dsHocSinh)
        {
            Console.WriteLine("Ten: " + hocSinh.Key + ", Diem: " + hocSinh.Value);
        }
    }
}
